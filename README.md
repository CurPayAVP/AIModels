# AIModels
CurPay AI Models

These example regression models are used in CurPay's Automated Volatility Protection (AVP)® software for smart trades in their Trader app and smart conversions to FIAT in their Merchant app.

They are the 1st stage of a 4 stage AI process that are trained using ML.net. 

In this stage the next rate (label) is determined by passing in the following indicators (features):
EMA10, EMA12, EMA17, EMA21, EMA100, EMA200, EMA26, MACD, Signal, RSI

For Help in understanding these indicators please refer to https://www.investopedia.com


The CurPay system trains each model using either LightGbm or FastForest regression trainers. During every train it is determined which is the most effective trainer based on the following, 

1.	Past performance
2.	Rsquared
3.	Mean Cross Validation Rsquared
4.	Mean Absolute Error
5.	Mean Squared Error
6.	Root Mean Squared Error
7.	Loss Function

Each file is named based on the Exchange, CurrencyPair and Long Term Short Term

CurPay_{ExchangeID}_{BaseCurrencyCode}_{ToCurrencyCode}_{LT_ST}.mlnet
For example Kraken BTC/USD Long Term outlook would be CurPay_3_BTC_USD_LT.mlnet

For help on consuming these models please refer to Microsoft's ML.net (https://dotnet.microsoft.com/en-us/apps/machinelearning-ai/ml-dotnet)





