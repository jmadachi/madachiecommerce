import { useEffect, useState } from "react"
import { Product } from "../../../models";
import { listProducts } from "../../../services/products.service";

export default function Products() {
    const [products, setProducts] = useState<Product[]>([]);

    useEffect(() => {
        const fetchProducts = async () => {
            const productsList = await listProducts();
            setProducts(productsList);
            console.log(productsList);
        };

        fetchProducts();
    }, []);

    return (
        <div>
            <h2>Products</h2>
            <table>
                <thead>
                    <tr>
                        <th>Code</th>
                        <th>Name</th>
                        <th>Price</th>
                    </tr>
                </thead>
                <tbody>
                    {products.map((product) => (
                        <tr key={product.id}>
                            <td>{product.code}</td>
                            <td style={{textAlign:'left'}}>{product.name}</td>
                            <td>{product.price.toLocaleString("es-CO", {
                                style: "currency",
                                currency: "COP",
                                minimumFractionDigits: 2,
                                maximumFractionDigits: 2
                            })}</td>
                        </tr>
                    ))}
                </tbody>
            </table>
        </div>
    )
}
