#veriyi istediğimiz formata getirmek için kullanırız string operasyonları kullanırız
import pandas as pd

orders=pd.read_table('original.tsv')
print(orders.head())
print(orders.columns)
orders.item_name=orders.item_name.str.upper()
print(orders.item_name) #sipariş isimlerinin hepsini büyük harfe dönüştürür.
print(orders.item_name.str.contains('chicken'.upper()))#sadece chicken diye aratsan bulamicaktı. sen onu datada büyük
#arama yaparkende büyüterek yap ki chicken içeren veriyi gör.
orders.choice_description =orders.choice_description.str.replace('[','') #[ yerine hiçbirşey koyma
