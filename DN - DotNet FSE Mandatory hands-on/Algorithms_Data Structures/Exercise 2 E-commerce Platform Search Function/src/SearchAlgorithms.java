import java.util.Arrays;
import java.util.Comparator;

public class SearchAlgorithms {

    // Linear Search
    public static Product linearSearch(Product[] products, int id) {

        for (Product product : products) {

            if (product.productId == id) {
                return product;
            }
        }

        return null;
    }

    // Binary Search
    public static Product binarySearch(Product[] products, int id) {

        int low = 0;
        int high = products.length - 1;

        while (low <= high) {

            int mid = (low + high) / 2;

            if (products[mid].productId == id)
                return products[mid];

            else if (products[mid].productId < id)
                low = mid + 1;

            else
                high = mid - 1;
        }

        return null;
    }

    // Sort products by ID
    public static void sortProducts(Product[] products) {

        Arrays.sort(products, Comparator.comparingInt(p -> p.productId));

    }
}