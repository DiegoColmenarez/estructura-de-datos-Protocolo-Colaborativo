from dataclasses import dataclass
import Product

@dataclass(frozen=True)
class SalesLine:
   
    product: Product
    sales_num: int
    
    @property
    def get_line_total(self) -> int:
    
       return self.product.price * self.sales_num
