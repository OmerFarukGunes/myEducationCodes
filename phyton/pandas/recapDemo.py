import pandas as pd
notlar = pd.read_csv("original.csv")
notlar.columns=["Last name","First name","SSN","test1","test2","test3","test4","final","sonuç"]#başka yerden aldığın dataları her daim düzenle yani temizle.
print(notlar)
print(notlar.head())
print(notlar["Last name"])
print(notlar["First name"])
print(notlar.iloc[2])
print(notlar[1:5])#1 den 5 e kadar değerleri al.