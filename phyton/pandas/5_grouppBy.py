import pandas as pd
films=pd.read_csv("imdb_1000.csv")
print(films.columns)
print(films.head())
print(films.star_rating.mean())#ortalamasını almak
print(films.groupby('genre').star_rating.mean())#türlere göre imdb puan ortalamasını yapıyor. 
