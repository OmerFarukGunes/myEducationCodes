import pandas as pd
import numpy as np
import matplotlib.pyplot as plt
from sklearn.linear_model import LinearRegression
from sklearn.metrics import r2_score
data =pd.read_csv("hw_25000.csv")
#biz burada boya göre kiloyu bulmak istiyoruz bu yüzden x boy y ise kilo olur.
boy=data.Height.values.reshape(-1,1)
kilo=data.Weight.values.reshape(-1,1)

regression = LinearRegression() #bir instance oluşturduk. yani bir class objesi
regression.fit(boy,kilo) # boy ve kiloya oranla bir ortalama değer elabilmek için reg e tabloyu tanımlıyoruz. eğimi vs hesaplayıp bizim için tahmin çizgisi
#tahmin line ı oluşturuyor.
print(regression.predict(np.array([[70]]))) # 70 inclik birinin olması gereken kilo
#print(regression.predict(boy)) #her bir boyun ortalama kilosunu ekrana yazar
print(data.columns)

plt.scatter(data.Height,data.Weight)
x= np.arange(min(data.Height),max(data.Height)).reshape(-1,1)  # x min kilo ve max kiloyu ele alacak.
plt.plot(x,regression.predict(x),color="red") #plot çizgi çizecek rengi kırmızı olacak ve x e göre çizecek.
plt.xlabel("Boy")
plt.ylabel("Kilo") #pilots kısmında oluşan grafiği bulacaksın.
plt.title("regressionLine") 
plt.show()
print(r2_score(kilo,regression.predict(boy))) #sapma olasılığını yani çizgi üzerinde olmayan o mavi noktalar yani y ler nedir ? sapma oranını söyler. 1 e ne kadar yakınsa o kadar doğrudur.
#bu data da oran %25 tir.