#dataframe de kolonlar yani sütünlar devreye girer.
import pandas as pd

data=[10,20,30,40,50]

df=pd.DataFrame(data)
print(df)
data2=[["omer",21,"Mardin"],["Faruk",18,"Adana"],["Gunes",22.5,"İstanbul"]]
df2=pd.DataFrame(data2)
print(df2)
df2=pd.DataFrame(data2,columns=["İsim","Yaş","Şehir"],index=[1,2,3]) #sütünları özelleştirebilirsin. anı şekilde indexleri
print(df2)

data3={"isim":["Ömer","Faruk","Güneş"],
       "Yaş":[18,20,22.5],
       "Şehir":["Mardin","Adana","iSTAnbul"]}
df3=pd.DataFrame(data3,index=[1,2,3])
print(df3)
print(df3["isim"])
del df3["Şehir"]#şehir kolonunu siler
df2.pop("Şehir") #buda aynı şekilde siler.
print(df2)
print(df3)

print(df3.loc[2]) #senin sıralamana göre 2. yi verir
print(df3.iloc[1]) #0 dan başlayarak verir

df4=df3.append(df2) #dataları ekler df3 e ve bunu df4 e eşitler
print(df4)
print(df4.head()) #en tepedeki ilk 5 datayı verir
print(df4.tail()) #son 5 datayı verir
