<?php
session_start();

require_once "config.php";
$total_price = 0;
if (isset($_POST['action']) && $_POST['action'] == "remove") {
    if (!empty($_SESSION["shopping_cart"])) {
        foreach ($_SESSION["shopping_cart"] as $key => $value) {
            if ($_POST["code"] == $key) {
                unset($_SESSION["shopping_cart"][$key]);
            }
            if (empty($_SESSION["shopping_cart"]))
                unset($_SESSION["shopping_cart"]);
        }
    }
}

if (isset($_POST['action']) && $_POST['action'] == "change") {
    foreach ($_SESSION["shopping_cart"] as &$value) {
        if ($value['code'] === $_POST["code"]) {
            $value['quantity'] = $_POST["quantity"];
            break; // Stop the loop after we've found the product
        }
    }
}

?>

<!DOCTYPE html>
<html>

<head>
    <title>Good Food Shopping Cart</title>
    <meta charset="utf-8">
    <link rel="stylesheet" href="style.css">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.2.1/css/all.min.css" integrity="sha512-MV7K8+y+gLIBoVD59lQIYicR65iaqukzvf/nwasF0nqhPay5w/9lJmVM2hMDcnK1OnMGCdVK+iQrJ7lzPJQd1w==" crossorigin="anonymous" referrerpolicy="no-referrer" />
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p" crossorigin="anonymous"></script>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">

</head>
<?php
if (isset($_SESSION['id']) && (isset($_SESSION['username'])) && (isset($_SESSION['rank']))) {
    if ($_SESSION['rank'] == 'Normal') {
        include "./header-normal.php";
    } else {
        include "./header-member.php";
    }
} elseif (!isset($_SESSION['id']) && (!isset($_SESSION['username']))) {
    include "./header.php";
}
?>

<body>
    <section class="h-100 h-custom" style="background-image:url(../GoodFood/images/bg.png)">
        <div class="container py-5 h-100">
            <div class="row d-flex justify-content-center align-items-center h-100">
                <div class="col-12">
                    <div class="card card-registration card-registration-2" style="border-radius: 15px;">
                        <div class="card-body p-0">
                            <div class="row g-0">
                                <div class="col-lg-8">
                                    <div class="p-5">
                                        <div class="d-flex justify-content-between align-items-center mb-5">
                                            <h1 class="fw-bold mb-0 text-black">Shopping Cart</h1>
                                        </div>
                                        <hr class="my-4">
                                        <?php
                                        if (isset($_SESSION["shopping_cart"])) {
                                            $total_price = 0;
                                        ?>
                                            <?php
                                            foreach ($_SESSION["shopping_cart"] as $product) {
                                                $total_price += floatval($product["price"] * $product["quantity"]);
                                            ?>
                                                <div class="row mb-4 d-flex justify-content-between align-items-center">
                                                    <div class="col-md-2 col-lg-2 col-xl-2">
                                                        <img src="../GoodFood/images/<?php echo $product["product_image"]; ?>" class="img-fluid rounded-3" alt="">
                                                    </div>
                                                    <div class="col-md-3 col-lg-3 col-xl-3">
                                                        <h6 class="text-muted"><?php echo $product["category"]; ?></h6>
                                                        <h6 class="text-black mb-0"><?php echo $product["product_name"]; ?></h6>
                                                    </div>
                                                    <div class="col-md-3 col-lg-3 col-xl-2 d-flex">
                                                        <form method='post' action='' style="padding-left: 50px;">
                                                            <input type='hidden' name='code' value="<?php echo $product["code"]; ?>" />
                                                            <input type='hidden' name='action' value="change" />
                                                            <select name='quantity' class='quantity' onChange="this.form.submit()">
                                                                <option <?php if ($product["quantity"] == 1) echo "selected"; ?> value="1">1</option>
                                                                <option <?php if ($product["quantity"] == 2) echo "selected"; ?> value="2">2</option>
                                                                <option <?php if ($product["quantity"] == 3) echo "selected"; ?> value="3">3</option>
                                                                <option <?php if ($product["quantity"] == 4) echo "selected"; ?> value="4">4</option>
                                                                <option <?php if ($product["quantity"] == 5) echo "selected"; ?> value="5">5</option>
                                                            </select>
                                                        </form>
                                                    </div>
                                                    <div class="col-md-3 col-lg-2 col-xl-2 offset-lg-1">
                                                        <h6 class="mb-0"><?php echo $product["price"]; ?></h6>
                                                    </div>
                                                    <div class="col-md-1 col-lg-1 col-xl-1 text-end">
                                                        <form method='post' action=''>

                                                            <input type='hidden' name='code' value="<?php echo $product["code"]; ?>" />
                                                            <input type='hidden' name='action' value="remove" />
                                                            <button type="submit" class="btn btn-primary" style="background-color:white;border:0;color:black;"><b>X</b></button>

                                                        </form>
                                                    </div>
                                                </div>
                                            <?php
                                            }
                                        } else { ?>
                                            <div class="row mb-4 d-flex justify-content-between align-items-center">
                                                <p style="margin:auto;text-align:center;">Cart is Empty!</p>
                                            </div>
                                        <?php } ?>
                                        <hr class="my-4">

                                        <div class="pt-5">
                                            <h6 class="mb-0"><a href="shop.php" class="text-body"><i class="fas fa-long-arrow-alt-left me-2"></i>Back to shop</a></h6>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-lg-4 bg-grey">
                                    <div class="p-5">
                                        <h3 class="fw-bold mb-5 mt-2 pt-1">Summary</h3>
                                        <hr class="my-4">

                                        <h5 class="text-uppercase mb-3">Voucher Code</h5>

                                        <div class="mb-5">
                                            <div class="form-outline">
                                                <input type="text" id="form3Examplea2" class="form-control form-control-lg" />
                                                <label class="form-label" for="form3Examplea2">Enter your code</label>
                                            </div>
                                        </div>
                                        <div class="d-flex justify-content-between mb-4">
                                            <h5 class="text-uppercase">Shipping fee</h5>
                                            <h5>RM 0</h5>
                                        </div>
                                        <div class="d-flex justify-content-between mb-4">
                                            <h5 class="text-uppercase">tax</h5>
                                            <h5>RM 0</h5>
                                        </div>
                                        <?php
                                        echo '<div class="d-flex justify-content-between mb-4">
                                        <h5 class="text-uppercase">Total Price</h5>
                                        <h5>RM ' . $total_price . '</h5>
                                        </div>';
                                        if (isset($_SESSION['rank']) && $_SESSION['rank'] == "Normal") {
                                            $discount_price = 0;
                                            $discount_price = number_format($discount_price, 2, '.', '');
                                            echo '<div class="d-flex justify-content-between mb-4">
                                                    <h5 class="text-uppercase">discount </h5>
                                                    <h5>- RM ' . $discount_price . '</h5>
                                                    </div>';
                                        } elseif (isset($_SESSION['rank']) && $_SESSION['rank'] == "Member") {
                                            $discount_price = $total_price * 0.1;
                                            $discount_price = number_format($discount_price, 2, '.', '');
                                            echo '<div class="d-flex justify-content-between mb-4">
                                                    <h5 class="text-uppercase">discount (10%)</h5>
                                                    <h5>- RM ' . $discount_price . '</h5>
                                                    </div>';
                                        } elseif (isset($_SESSION['rank']) && $_SESSION['rank'] == "Enthusiast") {
                                            $discount_price = $total_price * 0.15;
                                            $discount_price = number_format($discount_price, 2, '.', '');
                                            echo '<div class="d-flex justify-content-between mb-4">
                                                    <h5 class="text-uppercase">discount (15%)</h5>
                                                    <h5>- RM ' . $discount_price . '</h5>
                                                    </div>';
                                        }
                                        ?>

                                        <hr class="my-4">

                                        <div class="d-flex justify-content-between mb-5">
                                            <h5 class="text-uppercase">Final price</h5>
                                            <h5><?php echo "RM " . $total_price-$discount_price; ?></h5>
                                        </div>
                                        <?php
                                        if($total_price!=0){
                                            echo '<a href="#" class="w-100 btn btn-lg btn-primary" data-bs-toggle="modal" data-bs-target="#staticBackdropCart" style="background-color:black; border-color:black;">Make Payment</a>';
                                        }else{
                                            echo '<a href="#" class="w-100 btn btn-lg btn-primary" data-bs-toggle="modal" data-bs-target="#staticBackdropCartEmpty" style="background-color:black; border-color:black;">Make Payment</a>';
                                        }
                                        ?>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>

</body>
<div class="modal fade" id="staticBackdropCart" data-bs-backdrop="static" data-bs-keyboard="false" tabindex="-1" aria-labelledby="staticBackdropLabel1" aria-hidden="true">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title" id="staticBackdropLabel1">Payment Made</h5>
                    <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                </div>
                <div class="modal-body">
                    You have successfully paid!
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-primary" style="background-color:black;" onclick="location.href='index.php?paid=1'">Ok</button>
                </div>
            </div>
        </div>
    </div>
    <div class="modal fade" id="staticBackdropCartEmpty" data-bs-backdrop="static" data-bs-keyboard="false" tabindex="-1" aria-labelledby="staticBackdropLabel1" aria-hidden="true">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title" id="staticBackdropLabel1">Payment Failed</h5>
                    <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                </div>
                <div class="modal-body">
                    Your cart is empty!
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-primary" style="background-color:black;" onclick="location.href='shopping-cart.php'">Ok</button>
                </div>
            </div>
        </div>
    </div>
<?php include "./footer.php" ?>

</html>