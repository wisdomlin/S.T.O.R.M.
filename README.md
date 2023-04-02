# S.T.O.R.M.
Supply chain Tracking of Risk through Meteorological data (S.T.O.R.M.)

Welcome to this GitHub repository for tracking supply chain price fluctuations due to extreme weather events. Here are the key features:

1. This repository is designed to track the risks associated with supply chain price fluctuations caused by extreme weather events.
2. We have introduced a machine learning algorithm based on shape estimation to identify extreme weather events and price change points. We have also incorporated the inverse distance weighting method to assess the relationship between extreme weather events and price fluctuations.

![System Architecture](https://github.com/wisdomlin/STORM/blob/main/Figures/01_SystemArchitecture.png)

# How to Use
This project is developed based on Use Case Driven methodology, which means that all outputs are a combination of use cases.

Here are the instructions for reproducing the results of this paper based on the provided use cases located in the UseCases/UseCase.IntegrationTest directory:

## Spike Point Analysis Use Cases
1. Run the Test_Uc_Spa_FrTg_Parallel_199801_202206() method to detect all extreme temperature events in France (from January 1998 to June 2022).
2. Run the Test_Uc_Spa_FrRr_Parallel_199801_202206() method to detect all extreme precipitation events in France (from January 1998 to June 2022).

## Change Point Analysis Use Cases
1. Run the Test_Uc_Cpa_03_FrPrice_Paral_200501_202206() method to detect all price change points in France (from January 2005 to June 2022).

## Integration Analysis Use Cases (including early warning function) - Temperature Part
1. Run the Test_Uc_Ais_FrTg_2005_2019() method to integrate and analyze the correlation between extreme temperatures and price changes (from 2005 to 2019).
2. Run the Test_Uc_Ais_FrTg_2006_2020() method to integrate and analyze the correlation between extreme temperatures and price changes (from 2006 to 2020).
3. Run the Test_Uc_Ais_FrTg_2007_2021() method to integrate and analyze the correlation between extreme temperatures and price changes (from 2007 to 2021).
4. Run the Test_Uc_Ais_FrTg_2008_2022() method to integrate and analyze the correlation between extreme temperatures and price changes (from 2008 to 2022).

## Integration Analysis Use Cases (including early warning function) - Precipitation Part
1. Run the Test_Uc_Ais_FrRr_2005_2019() method to integrate and analyze the correlation between extreme precipitation and price changes (from 2005 to 2019).
2. Run the Test_Uc_Ais_FrRr_2006_2020() method to integrate and analyze the correlation between extreme precipitation and price changes (from 2006 to 2020).
3. Run the Test_Uc_Ais_FrRr_2007_2021() method to integrate and analyze the correlation between extreme precipitation and price changes (from 2007 to 2021).
4. Run the Test_Uc_Ais_FrRr_2008_2022() method to integrate and analyze the correlation between extreme precipitation and price changes (from 2008 to 2022).

# V Model
If you are interested in exploring the system implementation architecture further, you can refer to the following V Model diagram. In the diagram, we divide the system into two layers: the Entity layer and the Use Case layer. The Entity layer includes all reusable components developed during the development process, without implying any usage sequence. The Use Case layer, on the other hand, represents the application logic with usage sequences (flows) in various scenarios.
