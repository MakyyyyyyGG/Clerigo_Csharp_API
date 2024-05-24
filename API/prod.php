<?php
header("Content-Type: application/json");

$host = 'localhost';
$db = 'lara';
$user = 'root';
$pass = '';
$charset = 'utf8mb4';

$dsn = "mysql:host=$host;dbname=$db;charset=$charset";
$options = [
    PDO::ATTR_ERRMODE => PDO::ERRMODE_EXCEPTION,
    PDO::ATTR_DEFAULT_FETCH_MODE => PDO::FETCH_ASSOC,
    PDO::ATTR_EMULATE_PREPARES => false,
];

$pdo = new PDO($dsn, $user, $pass, $options);

if ($_SERVER['REQUEST_METHOD'] === 'GET') {
    $stmt = $pdo->query("SELECT product_id, product_name, product_price, product_stock, prod_img FROM prod");
    $products = $stmt->fetchAll();

    // Convert binary image data to base64
    foreach ($products as &$product) {
        $product['prod_img'] = base64_encode($product['prod_img']);
    }

    echo json_encode($products);
} elseif ($_SERVER['REQUEST_METHOD'] === 'POST') {
    $input = json_decode(file_get_contents('php://input'), true);

    // Assume prod_img is a base64 encoded string in the input
    $prod_img = base64_decode($input['prod_img']);
    
    $sql = "INSERT INTO prod (product_name, product_price, product_stock, prod_img) VALUES (?, ?, ?, ?)";
    $stmt = $pdo->prepare($sql);
    $stmt->execute([$input['product_name'], $input['product_price'], $input['product_stock'], $prod_img]);

    echo json_encode(['message' => 'Product added successfully']);
}
?>
