#elinde 100000 tane data var ama içlerinde rasgele 50000 tane ile örnek alınıp öyle işlem yapılıyor

import numpy as np
import pandas as pd
import matplotlib.pyplot as plt
from sklearn.ensemble import RandomForestRegressor

data = pd.read_csv("positions.csv")
level = data.iloc[:,1].values.reshape(-1,1)
salary = data.iloc[:,2].values # y değerimiz tek boyutlu olmak zrounda reshape yapmamalıyız.

regression = RandomForestRegressor(n_estimators = 10000,random_state=0) #ben rasgele 1000 veri ile çalışmak istiyordum eğer random state=0 yapmasaydım o tamamen aynı sonuç vermesini sağlar
#. ne kadar artarsa performans o kadar düşer ama daha net sonuç alırsın. 
regression.fit(level,salary)

print(regression.predict(np.array([[8.3]])))

