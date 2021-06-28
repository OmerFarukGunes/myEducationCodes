import { Component, OnInit } from '@angular/core';
import { Product } from './product';
import {AlertifyService} from '../services/alertify.service';
import { ProductService } from '../services/product.service';
import { ActivatedRoute } from '@angular/router';

declare let alertify:any;
//3. parti kaynaklardan bir script eklenince tanımazsa uygulama declare ile o tanımı js içerisinde aratıp bulmasını sağlar
@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css'],
  providers:[ProductService]
})
export class ProductComponent implements OnInit {

  constructor(private alertifyService:AlertifyService,private productSercive:ProductService, private activatedRoute:ActivatedRoute) { }
  title ="ürün listesi"
  filterText =""
  //ne gelirse gelsin demek any tip farketmiyor
  products? : Product[];
  
  //subscribe datayi istedigini bildirir
  ngOnInit(): void {  
    this.activatedRoute.params.subscribe(param=>{
      this.productSercive.getProducts(param["emailAddress"]).subscribe(data=>{this.products=data});
    })
  }
 addToCart(product: { name: string; }){
  this.alertifyService.success(product.name+" added");
 }
}
