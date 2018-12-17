namespace Library

module Say =
    let hello name =
        printfn "Hello %s" name

module Shopping = 
    type Category = { Name: string; ParentCategory: Option<Category> }

    type Product = { Name: string; Category: Category; PriceInCents: int}
    let rec sameOrChildOf(other: Category)(belongee: Category): bool = belongee.Name.Equals(other.Name) || defaultArg( Option.map(sameOrChildOf(other)) belongee.ParentCategory) false 
    let belongsToCategory(category: Category)(product: Product): bool = sameOrChildOf category product.Category

    let household = {Name = "Household"; ParentCategory = None}
    let kitchen = {Name = "Kitchen"; ParentCategory = Some(household)}
    let it = {Name = "IT"; ParentCategory = None}
    let computer = {Name = "Computer"; ParentCategory = Some(it)}
    let peripheral = {Name = "Peripheral"; ParentCategory = Some(it)}




    let iMac = {Name = "iMac"; Category = computer; PriceInCents = 200000}
    let thinkpad = {Name = "Thinkpad"; Category = computer; PriceInCents = 190000}
    let mouse = {Name = "Computer Mouse"; Category =  peripheral; PriceInCents = 1500}
    let pan = {Name = "Pan"; Category = kitchen; PriceInCents = 3900}
    
    let fork = {Name = "Fork"; Category = kitchen; PriceInCents = 140}
    let knive = {Name = "Knive"; Category = kitchen; PriceInCents = 220}


    let basket: List<Product> = [iMac; thinkpad; mouse; pan; fork; fork; knive]
    let smallBasket: List<Product> = [mouse; pan; fork]
