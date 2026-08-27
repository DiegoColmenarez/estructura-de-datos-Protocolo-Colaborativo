from typing import List

import SalesLine


class Calculator:    
    def calculate_total_sales(self, sales_line_list: List[SalesLine]) -> int: # type: ignore
        return sum(line.get_line_total() for line in sales_line_list)
    
    def get_best_selling(self, sales_line_list: List[SalesLine]) -> List[Product]: # type: ignore
        if not sales_line_list:
            return []
        
        # Encontrar el máximo de ventas
        max_sales = max(line.sales_num for line in sales_line_list)
        
        # Retornar todos los productos con ese máximo
        return [line.product for line in sales_line_list if line.sales_num == max_sales]
