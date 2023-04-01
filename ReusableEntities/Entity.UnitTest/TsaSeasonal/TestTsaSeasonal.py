import sys
import pandas as pd
import numpy as np
from statsmodels.tsa.seasonal import seasonal_decompose
from pathlib import Path

# food_name = 'Beef-and-veal'
food_name = 'Coffee-tea-cocoa'
## read inputFilePath (UT) - nonzeros
# df=pd.read_csv('D:\\Meta\\Uc_Cpa_Paral_Seasonal\\Original\\Fr\\Beef-and-veal.csv')
## read inputFilePath (UT) - zeros
df=pd.read_csv('D:\\Meta\\Uc_Cpa_Paral_Seasonal\\Original\\Fr\\' + food_name + '.csv')

df.head()

## 使用現有列設置 DataFrame 索引（行標籤）
df.set_index('TIME',inplace=True)
 
## drop null values
df.dropna(inplace=True)
 
## Do tsa, given column name, tsa model, period
# result=seasonal_decompose(df['Value'], model='multiplicable', period=12, extrapolate_trend='freq')
result=seasonal_decompose(df['Value'], model='additive', period=12, extrapolate_trend='freq')

## trend is (144,) array
## print(result.trend.values)
arr_trend = np.asarray(result.trend)
Path('D:\\Meta\\Uc_Cpa_Paral_Seasonal\\Trend\\Fr').mkdir(parents=True, exist_ok=True)
arr_trend.tofile('D:\\Meta\\Uc_Cpa_Paral_Seasonal\\Trend\\Fr\\Beef-and-veal.csv', sep = ',')

## seasonal is (144,) array
## print(result.seasonal.values)
arr_seasonal = np.asarray(result.seasonal)
Path('D:\\Meta\\Uc_Cpa_Paral_Seasonal\\Seasonal\\Fr').mkdir(parents=True, exist_ok=True)
arr_seasonal.tofile('D:\\Meta\\Uc_Cpa_Paral_Seasonal\\Seasonal\\Fr\\Beef-and-veal.csv', sep = ',')

## resid is (144,) array
## print(result.resid.values)
arr_resid = np.asarray(result.resid)
Path('D:\\Meta\\Uc_Cpa_Paral_Seasonal\\Residual\\Fr').mkdir(parents=True, exist_ok=True)
arr_resid.tofile('D:\\Meta\\Uc_Cpa_Paral_Seasonal\\Residual\\Fr\\Beef-and-veal.csv', sep = ',')

## Ploting Checking
# result.plot()

# Assert O=T*S*R
arr = arr_trend * arr_seasonal * arr_resid
original = np.asarray(result.observed.values)
Check = original - arr
print(Check)

# Save multiple arrays to a csv file with column names
# a = np.array([1,2,3,4])
a = []
# to iterate i from 2005 to 2006
for i in range(2005, 2008):
    # to iterate j from 1 to 2
    for j in range(1, 5):        
        if i == 2007 and j in {4,5}:
            continue
        else:
            s = '{0:04d}'.format(i) + 'M' + '{0:02d}'.format(j)
            a.append(s)
        
b = np.array([5.5,6.6,7.7,8.8,5.5,6.6,7.7,8.8,5.5,6.6,7.7])

df = pd.DataFrame({"name1" : a, "name2" : b})
df.to_csv('D:\\Meta\\Uc_Cpa_Paral_Seasonal\\Original\\Fr\\submission2.csv', 
          index=False, header=False)

 