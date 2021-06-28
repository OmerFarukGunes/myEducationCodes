import { Injectable } from '@angular/core';
declare let alertify:any;
//ınjectable heryerde ulaşılmasını sağlayan fonktur. ve ona root verdin mi mis
@Injectable({
  providedIn: 'root'
})
export class AlertifyService {

  constructor() { }
  //bu global bir yapıda olur ve bunun heryerde kullanabilirsin
  success(message:string){
    alertify.success(message)
  }
}
