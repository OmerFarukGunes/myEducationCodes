import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ProductAddForms1Component } from './product/product-add-forms1/product-add-forms1.component';
import { ProductComponent } from './product/product.component';

const routes: Routes = [
  {path:'products',component:ProductComponent},
  {path:'product-add-1',component:ProductAddForms1Component},
  {path:'product-add-2',component:ProductComponent},
  {path:'',redirectTo:'products',pathMatch:'full'},
  //link uzerinden : kullanarak degisken alabilirsin
  {path:'products/category/:categoryId', component:ProductComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
