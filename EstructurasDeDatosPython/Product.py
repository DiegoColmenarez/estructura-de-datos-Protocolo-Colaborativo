@dataclass(frozen=True)
class Product:

    id: str
    name: str
    price_in_cent: int  
    
    @property
    def price(self) -> int:
        return self.price_in_cent
