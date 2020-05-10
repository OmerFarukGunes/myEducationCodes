#include <iostream>
#include<stdio.h>

using namespace std;




int main(){
int sayi,yuzbinler,onbinler,binler,yuzler,onlar,birler;
cout<<"6basamaklý sayi giriniz"<<endl;
cin>>sayi;

yuzbinler=sayi/100000;
onbinler=(sayi % 100000 )/10000;
binler = (sayi %10000 )/1000;
yuzler =(sayi%1000 )/100;
onlar =(sayi%100 )/10;
birler =sayi %10;
cout<<sayi<<" "<< yuzbinler<<" "<< onbinler<<" "<<binler<<" "<<yuzler<<" "<<onlar<<" "<<birler;

return 0;
}
