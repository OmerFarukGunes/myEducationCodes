import numpy as np
import pandas as pd
import matplotlib.pyplot as plt
from sklearn.linear_model import LinearRegression 
from sklearn.preprocessing import PolynomialFeatures

data =pd.read_csv("positions.csv")
#doğrusal değerler bazen işe yaramaz çünkü değerler polinom şeklinde artabilir. 
print(data.columns)
#bilgisayar mühendisinin seviyesi arttıkça maaş ne oluyor ?
level = data.iloc[:,1].values.reshape(-1,1) #1. indexi yani leveli aldık x eksenine
salary = data.iloc[:,2].values.reshape(-1,1)# 2. elemanın tamamını yani parayı aldık.

regression=LinearRegression()
regression.fit(level,salary)
print(regression.predict(np.array([[8.3]]))) #çok yalnış bir değer verebilir.


regressionPoly=PolynomialFeatures(degree = 4) #genelde 4 verilir grafiğe göre eğim derecesi vermen lazım.
levelPoly = regressionPoly.fit_transform(level) #benim elimde level değerlerim var onları polynom haline sokar mısın
regression2 = LinearRegression()
regression2.fit(levelPoly,salary) #levelımın polisine göre yeni çizgi çizilecek sanal olarak.
print(regression2.predict(regressionPoly.fit_transform(np.array([[8.3]])))) #polinomicalda baştan fit etmen gerekecek daha doğru bir tahmin verecektir.


plt.scatter (level,salary,color="red")
plt.plot(level,regression.predict(level),color="blue") #farkettiysen böyle yaparsan çizi düzlemsel olur ve bu hatalıdır.
plt.plot(level,regression2.predict(levelPoly),color="green") # bu şekilde ise çizgi polinomical olur ve daha düzenli olur.
plt.show()

