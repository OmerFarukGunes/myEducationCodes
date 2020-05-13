import sqlite3
connection = sqlite3.connect("chinook.db") 

cursor = connection.execute ("""select city,count(*) from Customers 
                              group by city having count(*)>1 order by city desc """)#hangi şehirde kaç müşteri var görebilirsin bu şekilde. Count ile hesaplarsın.
                              #isimleri büyük harften küçük harfe doğru sıralarsın.
                              #ve sayısı 1 den fazla olanları bana ver. 1 den fazla aynı şehir varsa bana ver demektir having count>1
for row in cursor:
    print("City = " +row[0]) #ilk şehri alıyoruz
    print("Count = " +str(row[1])) #sonra hesabını
connection.close()