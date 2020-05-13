import pandas as pd

films= pd.read_csv("imdb_1000.csv")
print(films)
print(films.columns)#datadaki verileri bu şekilde görebilirsin.
print(films.head()) #ilk 5 data
print(films.tail()) #son 5 data
print(films.title.head()) # bu şekildede ilk 5 ismi alabilirsin
print(films[['title','star_rating']].head())
print(films[:9][['title','star_rating']].head()) #ilk 10 veriden oluşan dataframe nin ilk 5 elemanını 
#seçtiğim kolumlara ait olanları göster.
print(films[(films['star_rating']>8.5)&(films['star_rating']<=9)])
# filmsler datasından star rating i 8.5 ten büyük ve 9 dan küçük 
#olan filmlere ait dataframe oluşturduk ve yazdık.
print(films[(films['star_rating']>8.5)&(films['star_rating']<=9)][['title','star_rating']]) #or için| bu 
#oluşan bu dataframe de sadece isim ve puanını yazdırmak istiyoruz.
print(films.query('star_rating >= 9.0 & star_rating>=9.2')) #9 dan büyük 9.2 den küçük dizileri verir.
print(films.query('star_rating >= 9.0 & star_rating>=9.2')[['title','star_rating']]) # bu şekildede istediğin sütünları alırsın.

