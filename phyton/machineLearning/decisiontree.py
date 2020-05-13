#bazen veriler o kadar dengesiz olur ki onları part part bölüp o şekilde karar şeması oluşturmamız gerek
#örneğin hava güzel mi ? evet veya hayıra göre verilen cevaptan olasılık değerlerine gider ve işlmeleri yaparız
import numpy as np
import matplotlib.pyplot as plt
import pandas as pd
from sklearn.tree import DecisionTreeRegressor

data=pd.read_csv("positions.csv")
level = data.iloc[:,1:2].values.reshape(-1,1)#maksat farklı yazmak 1 den 2 ye kadar indexli verilerin hepsini al
salary =data.iloc[:,2].values.reshape(-1,1)

regression = DecisionTreeRegressor()
regression.fit(level,salary)
print(regression.predict(np.array([[8.9]])))

plt.scatter(level,salary,color="red")
x=np.arange(min(level),max(level),0.01).reshape(-1,1)
plt.plot(x,regression.predict(x),color="orange")
plt.xlabel ("Level")
plt.ylabel("Salary")
plt.title("Decision Tree Model")
plt.show()
