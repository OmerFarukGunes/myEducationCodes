#include <iostream>
#include<stdio.h>
#include<bits/stdc++.h>
#include<string.h>
#include<stdlib.h>
#include<time.h>
#include"Hayvan.h"
#include<string>
#include<exception>
#include<vector>
#include<list>
#include<map>
using namespace std;
//using std::cout; şeklinde fonksiyonları tek tek tanımlayabilirsin.
void EkranaYaz(){
cout<<"Ben fonkum"<<endl;
}
void baslangic(){
string isim = "Kaan";
    float ksayi =6.2; //4 byte
    double sayi=3.4; //8byte
    char name= 'K';
    int number;//4 byte
    bool a=true; // 1 byte
    int tamsayi;
    cout<<ksayi;
    cout<<sayi<<endl;
    cout<<name<<endl;
    cout<<a<<endl;
    cout << isim << ksayi<<endl;

    scanf("%d",&number);
    cout<<number<<endl;
    cout<<number+sayi<<endl;
    EkranaYaz();

    cin>>tamsayi;
    cout<<tamsayi<<endl;
    char character;
    cin>>character; // % veya & yok ne girdiysen o þekilde devam
    cout<<character<<endl;
    cout<<float(number)/tamsayi<<endl;
    int x=0;
    int y=0;
    x=y++;//önce x i y ye eþitledi sonra y yi arttýrdýo
    cout<<x<<endl;
    }
void basamaklar(){

int sayi,yuzbinler,onbinler,binler,yuzler,onlar,birler;
cout<<"6basamaklı sayi giriniz"<<endl;
cin>>sayi;

yuzbinler=sayi/100000;
onbinler=(sayi % 100000 )/10000;
binler = (sayi %10000 )/1000;
yuzler =(sayi%1000 )/100;
onlar =(sayi%100 )/10;
birler =sayi %10;
cout<<sayi<<" "<< yuzbinler<<" "<< onbinler<<" "<<binler<<" "<<yuzler<<" "<<onlar<<" "<<birler;
}
 void karakterdizileri(){
    string isim;
    string soyisim;
    int yas;
    cout<<"isim soyisim ve yas giriniz"<<endl;
    cin>>isim>>soyisim>>yas;
    cout<<isim<<" "<< soyisim<<" "<< yas<<endl;
}
void ifelse(){
if(5>4){ // 0 dışında içine ne yazarsan yazz büyüktür küçüktür eşittir vs yoksa eğer hep true olur ve içine girer
    cout<<(5<4); //doğruluğunu sayısal olarak verir
    // && || ve veya klasik semboller
}
else if(5<4){
    cout<<(4<5);
}
else{
    cout<<"noluyo la";
}
}
void switchs(){
    int islem;
   cin>>islem;
   switch(islem){
   case 1: cout<<"1 secildi"; break;
   case 2: cout<<"2 secildi"; break;
   default:
    cout<<"hicbirsey secilmedi";
    break;
   }

}
void stoktutma(){
int stok;
cin>>stok;
int islem;
int adet;
cin>>islem;
switch(islem){
case 1:
    cin>>adet;
    stok-=adet;
    cout<<stok;
    break;
    case 2: cin>>adet;
    stok+=adet;
    cout<<stok;
    break;
    }
}
void whiledongusu(){
int fact;
int sonuc=1;
cin >>fact;
while(fact>=1){
  sonuc *= fact;

  fact--;
}
cout<<sonuc;
}
void dowhile(){
int sayi =10;
int cifttoplam=0;
int tektoplam=0;
do{
  if(sayi%2==0){
    cifttoplam +=sayi;
  }
  else{
    tektoplam +=sayi;
  }
  sayi--;
}while(sayi>0); //önce do yapar sonra while
cout<<cifttoplam<<endl<<tektoplam<<endl;
}
void carpim(){
    for(int x=1;x<11;x++){
        for(int y=1;y<11;y++){
            cout<<x<<" * "<<y<<" = "<<x*y<<endl;
        }
    }
    //for(;;) sonsuz döngü olur
}
void breakcontunie(){
int i=0;
do{
        if(i==5){
            i++;
            continue; //alttaki komutları çalıştırma ama döngüye devam et. //bu şekilde 5 yazmaz
        }
        else if(i==8){
            break;  //8 e kadar yazdıracak
        }
    cout<<i<<endl;
    i++;
}while(i<10);
}
void diziler(){
             int sayilar[5]={2,3,4,5};
             sayilar[4]=1;
             for(int i=0;i<5;i++){
                cout<<sayilar[i]<<endl;
             }
}
void charseies(){
  string isimler[3]={"Kaan","Mert","Omer"}; //isimler [3][20] şekilde yazardın c de.
  for(int i=0;i<3;i++){
    cout<<isimler[i]<<endl;
  }
}
void cokboyutluseries(){
 int matris[4][4]={{2,3,4,1},{6,7,8,9},{5,9,8,0},{56,54,43,23}}; //2,,4,1 virgül arası boşluk bırakamazsın ama 2,4,1 yaparsan son elemanı 0 yapar veya {} yaparsan 0 ile doldurur veya [4][4]; yaparsan saçma sapan doldurur
 for(int i=0;i<4;i++){
   for(int k=0;k<4;k++){
        cout<<matris[i][k]<<" ";

    }
 cout<<endl;
 }
}
void kisayontemharfsiralama(){
  string dizi;
  int sayac;
  cin>>dizi;
  sayac=dizi.length();
  cout<<sayac<<endl;
  sort(dizi.begin(),dizi.end());
  cout<<dizi<<endl;
}
void kisayontemsayisiralama(){
    int dizi[10]={9,6,5,7,3,4,2,1,0,8};
    sort(dizi,dizi+10);//başlangıç ve sonunu biliyorsan böyle yapabilirsin.
    for(int i=0;i<10;i++){
        cout<<dizi[i]<<endl;
    }
}
void harfsiralama(){

   char dizi[40]; //string dizi; de yapabilirsin c de ise öyle yapamazsın.
   int sayac=0,temp;
   cin>>dizi;
   while(dizi[sayac]!='\0'){
    sayac++;
   } //sayac=dizi.length(); bu kodda bu while ın işlemini görür.
   int i=0,j=0;

   while(i<sayac-1){
     j=i+1;
       while(j<sayac){
        if(dizi[i]>dizi[j]){
            temp = dizi[i];
            dizi[i]=dizi[j];
            dizi[j]=temp;
        }
        j++;
       }
       i++;
} //int i=0,j=0 dahil buraya kadar bunlar yerine
//sort(dizi begin(),dizi.end()); bailangıçtan itibaren bu şekilde sıralar.
//kısa yöntemde bunu görebilirsin.
cout<<dizi<<endl;
 kisayontemharfsiralama();
 kisayontemsayisiralama();
}
void dizielemanlarisiralama(int dizi[],int boyut);
void fonksiyonlar(){
    int sayilar[3]={1,2,3};
    dizielemanlarisiralama(sayilar,3);
    }
void dizielemanlarisiralama(int dizi[],int boyut){
for(int i=0;i<boyut;i++){
    cout<<dizi[i]<<endl;
}
}
int toplam(int sayi1,int sayi2){
    return sayi1+sayi2;
}
void toplama(){
 int x=5,y=6;
 int sonuc=toplam(x,y);
 cout<<sonuc<<endl;
 cout<<toplam(x,y)<<endl;
}
void overloading(){
cout<<"omer"<<endl;
}
void overloading(string isim){
cout<<"faruk"<<endl;
}
void isim(){
    overloading("blabla"); //farklı parametrelere sahip aynı adda olan birden fazla fonk oluşturabilirsin ve buna biz overloading deriz.
    overloading();
}
int topla(int x,int y){
return x+y;
}
double topla(double x,double y){
return x+y;
}
string topla(string x, string y){
return x+y;
}
void sayi(){
  cout<<topla(5,6)<<endl;
  cout<< topla(5.6,5.5)<<endl;
  cout<<topla("5","7")<<endl;
}
int iterativefact(int sayi){
int carpim=1;
for(int i=1;i<=sayi;i++){
    carpim *=i;
}
return carpim;
}
int recuresivefakt(int sayi){
 if( sayi==1 || sayi==0){
    return 1;
 }
 else{
    return sayi * recuresivefakt(sayi-1); //öz yineleme yapabilirsin böylede.
 }
}
int fibonacci(int sayi){
 if(sayi==1 || sayi==0){
    return 1;
 }
 else{
    return fibonacci((sayi-1))+fibonacci(sayi-2);
 }
}
void terimler(){
cout<<iterativefact(5)<<endl;
cout<<recuresivefakt(5)<<endl;
cout<<fibonacci(0)<<endl; //if e giriyor
cout<<fibonacci(1)<<endl; //ife giriyor
cout<<fibonacci(2)<<endl; //else giriyor (2-1)+(2-2) yapıp fonku tekrar döndürüyor yani1 ve 0 ı ikiside 1 i return eder ve toplam 2 olur.
cout<<fibonacci(3)<<endl;
cout<<fibonacci(4)<<endl;
cout<<fibonacci(5)<<endl;

}
void expointer(int *x,int *y){
  int temp;
  temp=*x;
  *x=*y;
  *y=temp;
}
void pointer(){
int sayi1=5,sayi=10;
int *adres=&sayi;
cout<<adres<<endl;
cout<<adres+1<<endl; //bir sonraki adrese gider +1 demek 4 byte ilerlemek demektir.
cout<<*adres<<endl;
expointer(&sayi1,&sayi);
cout<<sayi1<<" "<<sayi; //sayi1 10 sayi 5 olacak artık çünkü adres üzerinden fonkta değişiklik yapıldı
}
void charpointer(){
char isim[10]="omer";
char *adres=isim;
char *adres2=&isim[0];
cout<<*adres<<" "<<*adres2<<endl;
for(int i=0;i<strlen(isim);i++){
 cout<<*(adres+i);
}
cout<<endl;
string name="Kaan";
string *adress= &name;
cout<<adress<<endl;
cout<<*adress<<endl;
string names[]={"Gs","Fb","Bjk"};
string *adresses=names; // ya da = &names[0] fonksiyonlarada bu şekilde gönderim yaparsın
cout<<adresses<<endl;
cout<<*adresses<<endl;
cout<<*(adresses+1)<<endl;
cout<<*(adresses+2)<<endl;
}
int maksimum(int *adress,int boyut){
int buyuk=adress[0];
for(int i=1;i<boyut;i++){
    if(buyuk<adress[i]){
        buyuk=adress[i];
    }
}
return buyuk;
}
void maksboyut(){
int sayilar[]={3,10,8};
cout<<maksimum(sayilar,3)<<endl;

}
void araligibastir(const int *x,const int *y){
for (;x!=y;x++){
    cout<<*x<<endl;
}
}
int consttopla(const int x, const int y){
return x+y;
}
void diziyazdir(const string *adress){
const string *gecici=adress;
for(;adress !=(gecici+2);adress++){
    cout<<*adress<<endl;
}
}
void cppspecial(){
const int sayi=25;
int sayi1 =55;
int &referans=sayi1;
referans++;//sayıyıda 1 arttırır.
//sayi = 30 yapamazsın ! sadece get eder set etmez.
cout<<sayi<<endl;
cout<<sayi1<<endl;
int sayilar[]={1,2,3,4,5};
araligibastir(sayilar+1,sayilar+4);
cout<<consttopla(5,6)<<endl;
string dizi[]={"Omer","Faruk","Gunes"};
diziyazdir(dizi);
}
void details(){
int x,y,t;
x=5;
y=6;
t = (x<y) ? x:y ;
cout<<t<<endl;
// cout<<"Naber\nNasilsin\a\t iyiyim"; // \a ses çıkartır
int z;
srand(time(NULL)); //null yerine 0 da yazabilirsin.
z=rand()%10;
cout<<z<<"\n";
string isim ="Omer Faruk";
int sayac=0;
for (char karakterler :isim){
    sayac++;
    cout<<karakterler;
}
cout<<endl<<sayac;
}
struct Ogrenci{
int numara;
string isim;
string soyisim;
string bolum;
bool cinsiyet;
};
void ismidegistir(Ogrenci *degistirme,string newname){
    degistirme->isim=newname;
}
void ogrenciolustur(Ogrenci *newogrenci,int numara,string isim){
newogrenci->numara=numara;
newogrenci->isim=isim;
}
void ogrenci(Ogrenci ogr){
cout<<ogr.isim<<" "<<ogr.numara;
}
void structures(){
Ogrenci ogr1 ={2017556029,"Omer","FG","Bil Muh",1};
Ogrenci ogr2;
cout<<ogr1.numara<<endl;
cout<<ogr1.isim<<endl;
cout<<ogr1.soyisim<<endl;
cout<<ogr1.bolum<<endl;
cout<<ogr1.cinsiyet<<endl;
ismidegistir(&ogr1,"Fatih");
cout<<ogr1.isim<<endl;
ogrenciolustur(&ogr2,21431,"Omer FG");
ogrenci(ogr2);
}
struct Kategori{
string isim;
int adet;

};
struct reyonlar{
 string isim;
 bool active;
 int sayi;
 Kategori kategoriler;
};
void stoktanDusur(reyonlar *reyon,int satilanlar){
reyon->kategoriler.adet -=satilanlar; //ok sadece pointerlarda kullanılır.
reyon->sayi -=satilanlar;
}
void structerinstructer(){
reyonlar r1={"Kuru Gida",1,200,{"Makarna",130}};
cout<<r1.isim<<" "<<r1.active<<" "<<r1.sayi<<" "<<r1.kategoriler.isim<<" "<<r1.kategoriler.adet<<endl;
stoktanDusur(&r1,30);
cout<<r1.isim<<" "<<r1.active<<" "<<r1.sayi<<" "<<r1.kategoriler.isim<<" "<<r1.kategoriler.adet<<endl;

}
void bellekyonetimi(){
int *adress = new int; // 4bytlık yer ayırır bu tanım
*adress = 10;
cout<<*adress<<endl;
delete adress; //silme komutu
*adress=12;
cout<<*adress<<endl; //sadece içini boşaltıyorsun ama ulaşabilirsin.
adress=nullptr;// ancak bunu yaptığında ulaşamazsın.
adress= 0; //bu şekildede yapabilirsin. ve erişimi iptal edersin.
int boyut=3;
int *adres= new int(boyut);
*adres=10;
*(adres+1)=12;
*(adres+2)=13;
for(int i =0;i<3;i++){
    cout<<*(adres+i)<<endl;
}
delete []adres;
adres=nullptr;
for(int i=0;i<3;i++){
    cout<<*(adres+i)<<endl;
}
}
class Insan{
 public: //aşağıdakiler herkese açık bilgiler olur.
 string isim;
 string gozrengi;
private:
 int bakiyesi; //bu private olur ve başka yerden ulaşılamaz.
 string irk;
 public:
 //private ozellikler için ulaşımı şöyle sağlayabiliriz.
 void setBakiyeIrk(int bakiye,string irki){
 bakiyesi=bakiye;
 if(irki.size()>=3){ //private stringlerin uzunluklarını böyle öğrenebilirsin ve ona göre işlem yapabilirsin.
    irk=irki;
 }
 }
 void ozelliklerisoyle(){
 cout<<isim<<" "<<gozrengi<<" "<<bakiyesi<<" "<<irk<<endl;
}
//ya da böyle
int getbakiye(){
return bakiyesi;
}
string getkirk(){
return irk;
}
~Insan(){ //alt gr ü ve boşluk basınca işaret çıkar ve bu classı yok eder bellekten siler.
cout<<"OBJE YOK EDILDI"<<endl;
  }
};
void privates(){
  Insan insan1;
  insan1.isim="Kaan";
  insan1.gozrengi="Ela";
  insan1.setBakiyeIrk(1000,"akit"); //eğer 2 harfli ırk gönderirsen ekrana yazmaz.
 // cout<<insan1.isim<<" "<<insan1.gozrengi<<endl; // struct içindeki gibi yazabilirsin. aşağıdan çağırığ
  insan1.ozelliklerisoyle();
cout<<insan1.getbakiye()<<endl;
  //2. bir insanı tanımlayıp yine aynı fonkla çağırabilirsin.
  Insan *insan2 =new Insan();
  insan2->isim="omer";
  insan2->gozrengi="siyah";
 insan2->setBakiyeIrk(-100,"Turk");
 insan2->ozelliklerisoyle();
 delete insan2; //bu şekilde objeyide yok edebilirsin.
}
void header(){
//bir proje düşün farklı farklı objelere sahip sen o objeleri toplu bir şekilde tutmak
//sadece main dosyana yığmamak için file -> new file -> empty file -> yes
//diyip .h ile biten header dosyaları açar objelere yani classları o kodlama dosyaı içinde
//kodlar ve burada kullanırsın.
//hayvan.h ı include etmelisin.

Hayvan hayvan1;
hayvan1.isim="Josi";
hayvan1.sinif="Kopek";
hayvan1.tur="Sosis";
hayvan1.yas=5;
hayvan1.ozelliklerisoyle();
}
class animal{

            private:
            string isim;
            string tur;
            int yas;
            public:
            animal(){
            this->isim="null";
            this->tur="Null";
            this->yas=0;
            }
            bilgileriguncelle(string ismi, string turu,int yasi){
            this->isim=ismi;
            this->tur=turu;
            this->yas=yasi;
            }
            bilgilerigetir(){
            cout<<this->isim<<" "<<this->tur<<" "<<this->yas<<endl;
            }
//animal();
};
//animal::animal(
 //                 this->isim="null";
   //         this->tur="Null";
     //       this->yas=0;
       //     } animal() constructorunu böylede tanımlayabilirsin.
void defaultconstructor(){
    animal animals[3];
   animal h1;
   animal h2;
   animal h3;
   animals[0]=h1;
     animals[1]=h2;
       animals[2]=h3;
       string isim;
       string tur;
       int yas;
       for(int i=0;i<3;i++){
        cin>>isim>>tur>>yas;
        animals[i].bilgileriguncelle(isim,tur,yas);
       }
       for(int i=0;i<3;i++){
      animals[i].bilgilerigetir();
       }

}
class tarih{
  private:
      int gun;
      int ay;
      int yil;
  public:
    tarih(int g,int a,int y){
    gun=g;
    ay=a;
    yil=y;
    }
    void tarihigoster(){
    cout<<gun<<"."<<ay<<"."<<yil<<endl;
    }
};
class person{
private:
    string isim;
    tarih dogumtarihi;
public:
    person(string i,tarih dt):isim(i),dogumtarihi(dt){} //basit şekilde böyle tanım yapar ve atamaları halledebilirsin
 void bilgilerigoster(){
 cout<<isim<<" ";
 dogumtarihi.tarihigoster();
 }
};
void kompozisyon(){
 tarih dogumtarihi(1,12,2018);
 dogumtarihi.tarihigoster();
 person i1("Omer FG",dogumtarihi);
 i1.bilgilerigoster();
}
class num{
public:
    int deger;
public:
    num(){}
    num (int s1){
    deger=s1;
    }
    num operator+(num s2){
    num toplam;
    toplam.deger=deger +s2.deger;
    return(toplam);
    }
};
void sayitipi(){
  num sayi1(10);
  num sayi2(33);
  num sayi3;
  sayi3 = sayi1+sayi2;
  cout<<sayi3.deger<<endl;
}
class deneme{
    public:
  string name;
   deneme(){
    cout<<"bos constructor li obje oluştu"<<endl;
   }
   deneme(string name){
   this->name = name; //eğer iki tarafta aynı isme sahipse this kullanırız. bu demektir.
   cout<<this->name<<" dolu constructor li obje oluştu"<<endl;
   }
};
class pluss{
 private:
     int sayi1,sayi2;

 public:
    pluss(int sayi1,int sayi2):sayi1(sayi1),sayi2(sayi2){}
    pluss(const pluss &kopya):sayi1(kopya.sayi1),sayi2(kopya.sayi2){} //const pluss &kopya int sayi 1 ve int sayi 2 operatörlerini kopyalar.
    void sonuc (){
    cout<<sayi1+sayi2<<endl;
    }
};
void copyconstructor(){
    deneme i1;
    deneme i2("Omer");
    pluss t1(15,22);
    pluss t2(t1);
    t1.sonuc();
    t2.sonuc();
}
class DeOgrenci{
private:
    string isim;
    int numara;
public:
    DeOgrenci(string isim,int numara){
    this->isim=isim; //this demezsen neyi neye atayacağını çözemez program
    this->numara=numara;
    }
    DeOgrenci(string isim){
    this->isim=isim;
    numara=0;
    }
    ~DeOgrenci(){
    cout<<"Obje yok edildi"<<endl;
    } //altgr ve ü ye basıp boşluk abs.

    void setIsim(string isim){
    if(isim.size()>=3){
       this-> isim=isim;
    }
    else{
            cout<<"Lutfen 3 ve 3 harften fazla har degeri giriniz"<<endl;
    }
    }
    void setNumara(int numara){
    if(numara>0){
       this->numara=numara;
       }
       else{
        cout<<"Lutfen sifirdan buyuk bir deger giriniz"<<endl;
       }
    }
    void ogrenciBilgileriniGoster(){
    cout<<"Isim : "<<this->isim<<endl;
    cout<<"Numara: "<<numara<<endl;//farketmez this yazmak ya da yazmamak.
        }
        string getIsim(){
        return isim;
        }
        int getNumara(){
        return numara;
        }

};
void deConstructor(){
    DeOgrenci *ogr1=new DeOgrenci("Kaan Academy",32432);
    ogr1->ogrenciBilgileriniGoster();
    delete ogr1;
    //tekrar bilgileri gösteremezsin.
}
class A{
public:  //her yerden erişim alırsın.
    int x;
};
class B{
protected:  //sadece kalıtım yaparsan alırsın.
    int y;
};
class C{
private:  //sadece kendi içerisinde değişir.
    int z;
public:
    void setZ(int deger){
    z=deger;
    }
    void getZ(){
    cout<<z<<endl;
    }
};
class D:public A,public B,public C{
public:
       D(){
   y=5;
   }
public:
    void getY(){
    cout<<y<<endl;
    }
};
void pubpripro(){
 D d1;
 d1.x=10;
 cout<<d1.x<<endl;;
 d1.getY();
    d1.setZ(1000);
   d1.getZ();

}
class takim{
    public:
  string isim;
  int kurulusYili;
  void yazdir(){
  cout<<"Takim sinifi"<<endl;
  }

};
class Futbolcu: public takim{ //takımı miras alıyorsun. bunların özelliklerini kullanabilirsin.
  private:
    string isim = "Bir isim belirtilmedi.";
   public:
    int dogumYili;
    float maas;

  public:
    string getIsim(){
      return isim;
    }
    void setIsim(string isim){
    this->isim=isim;
    }
};
void kalitim(){
   Futbolcu f1;
   takim *f1takim; //içindeki değişken değerleri aynı olduğundan kaynaklı pointer tanımladık.
   f1takim=&f1;
   f1.setIsim("Kaan");
   f1.dogumYili=1990;
   f1takim->isim="Galatasaray";
   f1.maas=12746;
   cout<<f1takim->isim<<" "<<f1.getIsim()<<" "<<f1.dogumYili<<" "<<f1.maas<<endl;
  f1takim->yazdir();
  f1.yazdir(); //farklı isimlerdeki metodlara direk pointer olmadan ulaşabilirsin.
}
class calisan{
private:
    string isim="default";
    float maas=0;
public:
    string getIsim(){
    return isim;
    }
    void setIsim(string isim){
      this->isim=isim;
    }
};
void uncopcullacion(){
calisan c1;
c1.setIsim("Omer");
cout<<c1.getIsim()<<endl; //kapsülleme olayı budur.
}
class Altin{
public:
int ayar;
int miktari;
public:
    void miktar(){
    cout<<miktari<<endl;
    }
};
class Demir{
public:
    int Miktarr;
public:
    void miktar(){
    cout<<Miktarr<<endl;
    }
};
class motor: public Altin,public Demir{

public:
    int devirSayisi;
    int kullanilanAltin;
    int kullanilanDemir;


};
void coklukalitim(){
motor m1;
m1.devirSayisi=1600;
m1.kullanilanAltin=5;
m1.kullanilanDemir=1000;
m1.miktari=m1.kullanilanAltin; //biz motor içindeki verileri doldurduk bunları gerekli yerlere eşitlememiz lazım.
m1.Miktarr=m1.kullanilanDemir;
m1.Altin::miktar();
m1.Demir::miktar(); //eğer isim olarak çakışma varsa yerini belli etmek için :: kullanıl ve belli edersin.
}
class Kitap{
public:
    string isim;
public:

    void bilgileriSoyle(){
    cout<<isim<<endl;
    }
};
class Roman: public Kitap{
   public:
       string romanTipi; //kısa orta uzun.
   public:
           Roman(string isim,string romanTipi){
     this->isim=isim; // miras aldığı ismi doldurcak
     this->romanTipi=romanTipi;
    }
    void bilgileriSoyle(){
    cout<<"Roman ismi: "<<isim<<"Roman tipi: "<<romanTipi<<endl;
    }
};
void overroading(){
 Roman r1("Dokuzuncu Harciye Kogusu","Uzun");
 r1.bilgileriSoyle();
 Kitap *r1Ebeveyn;
 r1Ebeveyn= &r1;
 r1Ebeveyn->bilgileriSoyle();


}
class hayvan{
public:
string ses="Default";
public:
    void sesCikar(){
    cout<<ses<<endl;
    }
};
class Kedi: public hayvan{
public:
    Kedi(){
    ses="Miyav";
    }

};
class Kopek: public hayvan{
public:
    Kopek(){
    ses="Hav Hav";
    }
};
class Kus: public hayvan{
public:
    Kus(){
    ses="Cik Cik";
    }

};
void polimorphisim(){ //çok biçimlilik demektir.
  Kedi k;
  k.sesCikar();
  Kopek ko;
  ko.sesCikar();
  Kus Ku;
  Ku.sesCikar();
}
 /*template<class DonusTipi>
DonusTipi Toplama(DonusTipi sayi1, DonusTipi sayi2){
return sayi1+sayi2;
} */ //aynı anda iki template oluşturamazsın.
template<class isminTipi,class soyadinTipi>
isminTipi Bilgi(isminTipi isim,soyadinTipi soyadi){
return isim+" "+soyadi;
}
void templatee(){
//cout<<Toplama<int>(10,25); //template donus tipini sonradan göndermeni sağlar.
cout<<Bilgi<string,string>("Kaan","Academy")<<endl;
}
void scopenamespace(){
  //en tepeye using std::cout;
  //using std::endl; şeklinde sadece lazım olan fonkları kullanabilirsin.
 /*namespace matematikselIslemler{
 float PI=3,14;
int PLUS(int sayi1,int sayi2){
return sayi1+sayi2;

}
float dairenCevre(float yaricap){
return 2*PI*yaricap;
}
}
 boş bir kodda bu şekilde kendi namespaceini oluşturabilirsin.
 kullanmak için using namespace matematikselıslemler;
 veya using matematikselislemler::Pi;
*/
}
void codeblocks(){ //scopelar denir

int sayi1=15;
int sayi2 =30;
{  //cod bloğu veya scope olarak adlandırılılr.
    int sayi1=20;
    sayi2=50;  //uzaydaki sayi2 yi arar ve bulur onu değiştirir.
    cout<<sayi1<<endl;
    cout<<sayi2<<endl;
}
cout<<sayi1<<endl;
cout<<sayi2<<endl;
}
void exceptions(){
string webSitesi;
cout<<"Site adi giriniz"<<endl;
cin>>webSitesi;
 try{
 if(webSitesi != "google.com"){
    throw 404; //404 ü fırlattı ve catch onu yakaladı.

}

}
catch(int hataKodu){
    cout<<"Aradiginiz web sitesi bulunamadi. Hata Kodu: "<<hataKodu<<endl;
 }
}
void BubbleSort(){
    //baloncuk / kabarcık sıralaması.
    //aslında bildiğin konu dizileri sıralamaya sokuyorsun ya iki for döngüsünde
    //işte onun ismi bubblesort imiş.
}
void selSort(int dizi[],int boyut){
    int minIndex;
    for (int i=0;i<boyut;i++){
        minIndex=i;
        for(int j=i;j<boyut;j++){
            if(dizi[j]<dizi[minIndex]){
                minIndex=j;
            }
        }
        int temp=dizi[i];
        dizi[i]=dizi[minIndex];
        dizi[minIndex]=temp;
    }
    for(int i=0;i<boyut;i++){
        cout<<dizi[i];
    }

}
void selectionSort(){
    // seçimli sıralama.
    // 5 9 4 6 15
    //tüm dizide dolaş en küçük değeri en başa at.
    // 4 5 9 6 15
    //kalan dizide dolaş en küçük değeri kalan dizinin başına at.
    //4 5 6 9 1 15 diye gidiyor.
  int boyut;
  cout<<"eleman sayisi"<<endl;
  cin>>boyut;
  int dizi[boyut];
  cout<<"gir"<<endl;
  for(int i=0;i<boyut;i++){
  cin>>dizi[i];
  }
  selSort(dizi,boyut);

}
void insertSort(int dizi[],int boyut){
    int element;
    int oncesi;
    for(int i=1;i<boyut;i++){
        element=dizi[i];
        oncesi= i-1;
        while(oncesi>=0 && dizi[oncesi]>element){
            dizi[oncesi+1]=dizi[oncesi];
            oncesi--;
        }
        dizi[oncesi+1]=element;
    }
    for(int i=0;i<boyut;i++)
        cout<<dizi[i];

}
void insertionSort(){
    //araya sokma/ekleme sıralaması.
    //15 51 16 7 64
    //2. eleman sola doğru kontrol edecek. 51 15 ten büyük kalsın yerinde
    //16 51 den büyük mü değil hayır o zaman 16 yı 15 51 arasına sok. gibi gibi
     int boyut;
  cout<<"eleman sayisi"<<endl;
  cin>>boyut;
  int dizi[boyut];
  cout<<"gir"<<endl;
  for(int i=0;i<boyut;i++){
  cin>>dizi[i];
  }
  insertSort(dizi,boyut);
}
int liSearch(int dizi[],int x,int boyut){
    for(int i=0;i<boyut;i++){
        if(dizi[i]==x){
            return i;
        }
    }
    return -1;
}
void linearSearch(){
    //düz arama algoritmasıdır.
int sayilar[]={3,5,1,-4,9,12};
int boyut= sizeof(sayilar)/sizeof(int);
int arananDeger;
cout<<"aranan deger:"<<endl;
cin>>arananDeger;
int aramaSonucu;
aramaSonucu=liSearch(sayilar,arananDeger,boyut);
cout<<aramaSonucu<<endl;
}
int binarySearch(int dizi[],int enDusuk,int enYuksek,int arananDeger){
while(enDusuk<=enYuksek){
    int ortadakiSayi=enDusuk+(enYuksek-enDusuk)/2;
    if(dizi[ortadakiSayi]==arananDeger)
        return ortadakiSayi;
    if(dizi[ortadakiSayi]<arananDeger)
        enDusuk=ortadakiSayi+1;
    else
        enYuksek=ortadakiSayi-1;
}
return -1;
}
void binarySearch(){
    int sayilar[]={2,5,7,14,24,36,67};
    int boyut=sizeof(sayilar)/sizeof(int);
    int aranilanSayi;
    while(1){
        cout<<"Indeksini ogrenmek istediginiz sayiyi giriniz"<<endl;
        cin>>aranilanSayi;
        int aramaSonucu=binarySearch(sayilar,0,boyut-1,aranilanSayi);
        if(aramaSonucu>=0)
            cout<<"aradiginiz sayi "<<aramaSonucu<<".indekstir"<<endl;
    else
        cout<<"aradiginiz sayi bulunamamaktadir."<<endl;
    }
}
void functionOfString(){
string isim1;
cout<<"isim gir";
getline(cin,isim1); //satırı komple alır.
cout<<isim1<<endl;
string isim="kaan";
string isim2("fatih"); //aynı şey ikiside.
cout<<isim<<endl<<isim2<<endl;
string isim3;
isim3=isim;
cout<<isim3<<endl;
isim3.assign(isim2);
cout<<isim3<<endl;
isim3.assign("AAAA"); // ekler.
cout<<isim3<<endl;
cout<<isim1.at(3)<<endl; // 3. indisi alır yazar.
cout<<isim1.length()<<endl;//uzunluk.
cout<<isim1.substr(5)<<endl; // 5. indisten itibaren yazdır.
cout<<isim1.substr(5,3)<<endl; // 5. indisten itibaren 3 karakter yaz.
isim.swap(isim2);//isim 1 ve isim 2 yerleri değişir.
cout<<isim<<endl<<isim2<<endl;
isim.erase(3); //3. indisten sonrasını sil.
isim2.erase(2,1); //2 . indisten itibaren 1 karakter sil.
cout<<isim1.find("faruk")<<endl; // soldan itibaren faruk kaçıncı indisten başlıyor bulur.
cout<<isim1.rfind("es")<<endl; //sağdan itibaren es kelimseini arar ve nereden başlarsa yazar.
cout<<isim1.substr(isim1.rfind(" "),5)<<endl;
isim.replace(1,3,"aan");
cout<<isim<<endl;
}
void hataKontrol(){
    bool error1=true;
bool error2=false;
bool error3=true;
if(error1){
    throw 404; //throw işlemi olduğu anda fonktan çıkış yapar.
}
if(error2){
    throw string("sayga bulunamadi");
}
if(error3){
    throw "Bu bir const hatasidir";
}
}
void tryCatch(){
try{
hataKontrol();
}
catch(int e){
cout<<e<<endl;
}
catch(string e){
cout<<e<<endl;
}
catch (char const *e){ //ne gönderiyorsan o veri tipinde alım yapman lazım
cout<<e<<endl;
}
}
class standartIstisna{
public:
standartIstisna(){
char *hafizaYer =new char[99999999999999999999999]; //böyle birşey mümkün değil
delete[] hafizaYer; //Ondan kaynaklı hata kodu çıkacak bu default bir hata kodudur.
} //rami patlatmasın bir delete yazalım .d
};
void standartException(){
     try{
     standartIstisna yer;
     }
     catch(bad_alloc e){
         cout<<"boyle yer ayrilmaz "<<e.what()<<endl;
     }
}
class ourException: public exception{
public:
    virtual const char * what() const throw(){
    return "su anda bir hata yapiyorsunuz.";
    }
};
class Insans{
public:
    void hataFirlat(){
    throw ourException();
    }
};
void ourExceptionS(){
    Insans i1;
    try{
    i1.hataFirlat();
    }
    catch(ourException &e){
    cout<<e.what()<<endl;
    }
}
void vectors(){
vector<string>stringDizisi(5); //eleman tanımı yapmadan
stringDizisi.push_back("6.eleman"); //sadece push ile diziye çevirip ekleme yapabilirsin.
stringDizisi[3]="Kaan";
cout<<stringDizisi[3]<<endl;
cout<<stringDizisi.size()<<endl;
for(vector<string>::iterator iterat=stringDizisi.begin(); iterat != stringDizisi.end();iterat++){
    cout<<*iterat<<endl; //bu şekilde bir iterator ile diziyi baştan sona yazabilirsin.
}
vector<string>::iterator iter =stringDizisi.begin();
iter +=3;
cout<< *iter<<endl;
}
void lists(){
list<int> sayilar;
sayilar.push_front(0);
sayilar.push_back(1); //Listenin arkasına ekler.
sayilar.push_back(5); //listenin başıne ekler
list<int>::iterator iteratif =sayilar.begin();
cout<<*iteratif<<endl;
iteratif++; //1 den sonra 100 eklemek istiyoz bundan dolayı iteri oraya koyduk.
sayilar.insert(iteratif,100); //100 eklendi
iteratif=sayilar.end(); //sondaki elemanıda silmek istiyoruz.
sayilar.erase(iteratif);
iteratif=sayilar.begin(); //iteri başa aldık ve baştan yazdık.
for(int i=0;i<sayilar.size();i++){
    cout<<*iteratif<<endl;
    iteratif++;
}


}
void maps(){
map<int,string> sahis;
sahis[50] ="Kaan";
cout<<sahis[50]<<endl;//50. keyin valuesini getir
sahis[30]="ahmet";
sahis[20]="burcu";
for(map<int,string>::iterator adres=sahis.begin(); adres!=sahis.end();adres++){
    cout<<adres->first<<" "; //keylere ulaşır.
    cout<<sahis[adres->first]<<endl; //böylede valuelere.
}
}
int main()
{
    maps();
    //lists();
    //vectors();
     //  ourExceptionS(); //kendi istisnanı yarat ve ekrana yazdır.
    //standartException();
     //tryCatch();
    //functionOfString();
    //binarySearch();
    //linearSearch();
     //insertionSort();
     // selectionSort();
    // BubbleSort();
    // exceptions();
    // codeblocks();
   // scopenamespace();
    // templatee();
   // polimorphisim(); // 69. videoyu da izle.
      //overroading(); //çiğnemek atmak;
     //coklukalitim();
    //  uncopcullacion();
    // kalitim();
     // pubpripro();
   //  deConstructor();
        // copyconstructor();
       // sayitipi();
      //kompozisyon();
     // defaultconstructor();
    // header();
   //   privates();
   // bellekyonetimi();
  //structerinstructer();
  //structures();
    // details();
   // cppspecial();
   // maksboyut();
   // charpointer();
    //pointer();
    // terimler();
    // sayi();
    //isim();
    // toplama();
    //fonksiyonlar();
    // harfsiralama();
    // cokboyutluseries();
    // charseies();
    // diziler();
    // breakcontunie();
    // carpim();
    // dowhile();
    //  whiledongusu();
    // stoktutma();
    // switchs();
    //   ifelse();
    // karakterdizileri();
   // basamaklar();
   // baslangic();
    return 0;
}

