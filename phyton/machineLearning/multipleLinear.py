import pandas as pd
import numpy as np
import matplotlib.pyplot as plt
from sklearn.linear_model import LinearRegression
from sklearn.metrics import r2_score
data =pd.read_csv("insurance.csv")
print(data.columns)#her zaman ilk kolonlara bak .d

#y miz bizim bulmak istediğimiz şeydir. biz yaşa çocukluğa cinsiyete göre harcama bulmak istiyoruz

expenses =data.expenses.values.reshape(-1,1) #y eksenimiz oluştu 
ageBmis = data.iloc[:,[0,2]].values #tüm 1 ve 0 yani isim ve bmi değerlerini x ekseni için aldık.
regression =LinearRegression() #çizik lazım yani tahmini ortalama değer.
regression.fit(ageBmis,expenses)
print(regression.predict(np.array([[20,20],[20,21],[20,22],[21,20]]))) #bmi = body mass index 
#verdiğimiz yaş ve bmi lere göre tahmini harcamaları verir.
print(r2_score(expenses,regression.predict(ageBmis)))