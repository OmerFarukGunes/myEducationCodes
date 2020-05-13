import pandas as pd
data1={'id':[1,2,3,4],'ad':["omer","Faruk","Dogu","İrem"],'soyad':["Güneş","mutlu","Sorgu","Deveci"]}
data2={'id':[1,3,4,7],'ad':["ayşe","ali","mehmet","hasan"],'soyad':["gün","şen","olan","hasüs"]}
data1Df=pd.DataFrame(data1)
data2Df=pd.DataFrame(data2)
print(data1Df)
print(data2Df)
print(pd.merge(data1Df,data2Df,on='id',how='inner')) #id si aynı olanları yanyana getir
print(pd.merge(data1Df,data2Df,on='id',how='left')) #örneğin isimler solda siparişler sağda ismi olan ama benden sipariş vermeyenleri ekrana yaz demektir.
#misal 2. indexin sağda yani data2 de verisi yok.
print(pd.merge(data1Df,data2Df,on='id',how='right'))
print(pd.concat([data1Df,data2Df],axis=1)) #axis ile dizimleri yaparsın.

