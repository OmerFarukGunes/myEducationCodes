import json
data ='{"firstName":"Ömer", "lastName": "Güneş"}' #bu json formatıdır.
y=json.loads(data) #bu veriyi jsona çevirdik.
print(y["firstName"])

customer ={ "firstName":"engin"}#bu dictionarydir yani sözlüktür. yapısal olarak json formatındadır.

customerJson =json.dumps(customer)#phyton verisini yani dictionary,array,list vs jsona dumps fonku ile çeviririz.
print(json.dumps("OmerFG"))#misal burada stringi jsona dönüştürdük.


