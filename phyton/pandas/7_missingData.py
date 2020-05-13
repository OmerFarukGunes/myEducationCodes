import pandas as pd
url = "https://raw.githubusercontent.com/justmarkham/pandas-videos/master/data/ufo.csv"
data=pd.read_csv(url) #urlden bu şekilde okursun
print(data["City"].head())
print(data.isnull().head(100)) #boş olan ilk 100 datayı getir
print(data.notnull().head(100))#null olmayan ilk 100 veriyi getir
print(data.isnull().sum()) #boş olan kaç tane bdeğer var ?
print(data[data.City.isnull()]) #null olan şehirler.

print(data.columns)