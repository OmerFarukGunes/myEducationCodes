import pandas as pd
url = "https://raw.githubusercontent.com/justmarkham/pandas-videos/master/data/ufo.csv"
data=pd.read_csv(url) #urlden bu şekilde okursun
print(data['Shape Reported'].value_counts(dropna=False))#kaç tanedata var
data['Shape Reported'].fillna(value='unknown',inplace=True) #bu şekilde boş dataları doldurabilirsin. ve yerleştirebilirsin.
print(data['Shape Reported'].value_counts(dropna=False))