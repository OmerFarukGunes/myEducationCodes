import json
with open("rD8users.json") as users: #bir jason data dosyasını bu şekilde açar verdiğin isim(Users) ile kullanırsın
    data =json.load(users)
    print(data[0]) #bu şekilde istediğin dataya ulaşabilirsin. 
    print(data[1]["username"]) #bu şekilde istediğin datanın istediğin verisine ulaşabilirsin
    print(data[1]["address"]["geo"]) #istediğin kadar arttırabilirsin.
    for x in range(2,8):
        print(data[x]["username"])