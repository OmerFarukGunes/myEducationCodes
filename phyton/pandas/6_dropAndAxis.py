import pandas as pd
films=pd.read_csv("imdb_1000.csv")
print(films.columns)
print(films.drop("content_rating",axis=1).head()) #axis 1 kolon axis= 0 satır. burada  content rating sütununu uçuruyor
films=films.drop(2,axis=0)#2. indeksteki satırı sil
rows=[0,1,3,4,5,6,7,8,9]
films=films.drop(rows,axis=0) #dizilerle beraberde silebilir.
print(films) #eşitleme yapmadığın için sütun sadece o printte silindi.

