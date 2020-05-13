import numpy as np

a= np.floor(10*np.random.random((3,4)))

print(a)
print(a.shape)
print(a.ravel()) #diziti düzleştirir. diziyi hep bu şekilde kullanmak istersen atama yapman gerek a=a.ravel() şeklinde
print(a.reshape(2,6))#diziyi yeniden şekillendirir
print(a.T)#dizinin transpozunu alır.
print(a.reshape(2,-1)) #2 satır oluştur sen bana veri sayısına görede sütunları sen parçala be uğraştırma beni demektir. veriler eşit bölünmeli dikkat et! her satıra eşit olarak böler
