import { Pipe, PipeTransform } from '@angular/core';
import { Product } from './product';
import { filter } from 'rxjs/operators';
@Pipe({
  name: 'productFilter'
})
export class ProductFilterPipe implements PipeTransform {

  transform(value: Product[], filterText?: string): Product[] {
    //filter var mı varsa küçük harf yok yoksa birşey yapma
   filterText = filterText?filterText.toLocaleLowerCase():null!;
    return filterText?value.filter((p:Product)=>p.name.toLocaleLowerCase().indexOf(filterText!)!==-1):value;
  }

}
