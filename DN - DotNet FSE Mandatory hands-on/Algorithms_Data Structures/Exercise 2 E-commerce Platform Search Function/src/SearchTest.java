public class SearchTest {

    public static void main(String[] args) {

        Product[] products = {

                new Product(105, "Laptop", "Electronics"),
                new Product(101, "Mobile", "Electronics"),
                new Product(104, "Shoes", "Fashion"),
                new Product(102, "Watch", "Accessories"),
                new Product(103, "Book", "Education")

        };

        System.out.println("----- Linear Search -----");

        Product result1 = SearchAlgorithms.linearSearch(products, 104);

        if (result1 != null)
            result1.display();
        else
            System.out.println("Product Not Found");

        SearchAlgorithms.sortProducts(products);

        System.out.println("\n----- Binary Search -----");

        Product result2 = SearchAlgorithms.binarySearch(products, 104);

        if (result2 != null)
            result2.display();
        else
            System.out.println("Product Not Found");
    }
}