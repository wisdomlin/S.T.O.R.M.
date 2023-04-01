import sys
import pandas as pd
import numpy as np
from statsmodels.tsa.seasonal import seasonal_decompose
from pathlib import Path

## get system arguments
## Note: Each argument must not contain spaces, like "Bread and cereals"
OriginalFilePath = sys.argv[1]
TrendFilePath = sys.argv[2]
SeasonalFilePath = sys.argv[3]
ResidualFilePath = sys.argv[4]

## sys.argv checking
# text_file = open('D:\\sample.txt', "w")
# n = text_file.write(OriginalFilePath + "\n" 
#                     + TrendFilePath + "\n" 
#                     + SeasonalFilePath + "\n" 
#                     + ResidualFilePath)
# text_file.close()

## read inputFilePath
df=pd.read_csv(OriginalFilePath)

## 使用現有列設置 DataFrame 索引（行標籤）
df.set_index('TIME',inplace=True)
 
## drop null values
df.dropna(inplace=True)
 
## Do tsa, given column name, tsa model, period
result=seasonal_decompose(df['Value'], model='multiplicable', period=12, extrapolate_trend='freq')

# Save multiple arrays to a csv file with column names
# Prepare Column Index Array
a = []
# to iterate i from 2005 to 2019
for i in range(2005, 2020):
    # to iterate j from 1 to 12
    for j in range(1, 13):
        # if i = 2019 and j = 10,11,12, Skip. 
        if i == 2019 and j in {10,11,12}:
            continue
        else:
            s = '{0:04d}'.format(i) + 'M' + '{0:02d}'.format(j)
            a.append(s)
        

## trend is (144,) array
b = np.asarray(result.trend)
Path('D:\\Meta\\Uc_Cpa_Paral_Seasonal\\Trend\\Fr').mkdir(parents=True, exist_ok=True)
# b.tofile(TrendFilePath, sep = ',')
# Write CSV
df = pd.DataFrame({"name1" : a, "name2" : b})
df.to_csv(TrendFilePath, index=False, header=False)

## seasonal is (144,) array
arr = np.asarray(result.seasonal)
Path('D:\\Meta\\Uc_Cpa_Paral_Seasonal\\Seasonal\\Fr').mkdir(parents=True, exist_ok=True)
arr.tofile(SeasonalFilePath, sep = ',')

## resid is (144,) array
arr = np.asarray(result.resid)
Path('D:\\Meta\\Uc_Cpa_Paral_Seasonal\\Residual\\Fr').mkdir(parents=True, exist_ok=True)
arr.tofile(ResidualFilePath, sep = ',')


