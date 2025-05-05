<?php
session_start();

require_once "config.php";

if (isset($_GET['rank'])) {
        $id = $_SESSION["id"];
        $rank = $_GET['rank'];
        $sql = "UPDATE user SET subscription=? WHERE id=?";

        if ($stmt = mysqli_prepare($link, $sql)) {

            mysqli_stmt_bind_param($stmt, "si", $param_rank, $param_id);

            // Set parameters
            $param_rank = $rank;
            $param_id = $id;

            // Attempt to execute the prepared statement
            if (mysqli_stmt_execute($stmt)) {
                if($_GET['rank'] == 'Member'){
                    $_SESSION['rank'] = 'Member';
                    echo "<script>alert('You are now a Member!');</script>";
                }elseif($_GET['rank'] == 'Enthusiast'){
                    $_SESSION['rank'] = 'Enthusiast';
                    echo "<script>alert('You are now an Enthusiast!');</script>";
                }elseif($_GET['rank'] == 'Normal'){
                    $_SESSION['rank'] = 'Normal';
                    echo "<script>alert('You are now a regular user');</script>";
                }
            }
        }

        // Close statement
        mysqli_stmt_close($stmt);


        // Close connection
        mysqli_close($link);
    }

?>
<!DOCTYPE html>
<html class="subscription-bg" lang="en">

<head>
    <meta charset="UTF-8">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.2.1/css/all.min.css" integrity="sha512-MV7K8+y+gLIBoVD59lQIYicR65iaqukzvf/nwasF0nqhPay5w/9lJmVM2hMDcnK1OnMGCdVK+iQrJ7lzPJQd1w==" crossorigin="anonymous" referrerpolicy="no-referrer" />
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p" crossorigin="anonymous"></script>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
    <link rel="stylesheet" href="style.css">
    <title>Subscription</title>
</head>
<?php
  if (isset($_SESSION['id']) && (isset($_SESSION['username'])) && (isset($_SESSION['rank']))) {
    if($_SESSION['rank'] == 'Normal'){
      include "./header-normal.php";
    }else{
      include "./header-member.php";
    }
  } elseif (!isset($_SESSION['id']) && (!isset($_SESSION['username']))) {
    include "./header.php";
  }
  ?>

<body style="background-image:url(../GoodFood/images/bg.png);">
    <main style="height:650px;">
        <div class="row row-cols-1 row-cols-md-2 mb-2 text-center" style="margin: 150px 350px 0px 350px;">
            <div class="col">
                <div class="card mb-4 rounded-3 shadow-sm">
                    <div class="card-header py-3">
                        <h4 class="my-0 fw-normal">Member</h4>
                    </div>
                    <div class="card-body">
                        <h1 class="card-title pricing-card-title">RM15<small class="text-muted fw-light">/mo</small></h1>
                        <ul class="list-unstyled mt-3 mb-4" style="height:20vh;">
                            <li>Online shopping 10% discount off</li>
                            <li>Special monthly voucher</li>
                            <li>Access to special members only event activities</li>
                            <li>Meal plans suggestion</li>
                            <li>To be announced</li>
                        </ul>
                        <a href="#" class="w-100 btn btn-lg btn-primary" data-bs-toggle="modal" data-bs-target="#staticBackdrop1" style="background-color:black; border-color:black;">Subscribe Now</a>
                    </div>
                </div>
            </div>
            <div class="col">
                <div class="card mb-4 rounded-3 shadow-sm">
                    <div class="card-header py-3">
                        <h4 class="my-0 fw-normal">Enthusiast</h4>
                    </div>
                    <div class="card-body">
                        <h1 class="card-title pricing-card-title">RM50<small class="text-muted fw-light">/mo</small></h1>
                        <ul class="list-unstyled mt-3 mb-4" style="height:20vh;">
                            <li>Online shopping 15% discount off</li>
                            <li>Special monthly voucher</li>
                            <li>Free shipping</li>
                            <li>Access to special members only event activities</li>
                            <li>Meal plans suggestion</li>
                            <li>Get in touch with company chefs</li>
                            <li>To be announced</li>
                        </ul>
                        <a href="#" class="w-100 btn btn-lg btn-primary" data-bs-toggle="modal" data-bs-target="#staticBackdrop2" style="background-color:black; border-color:black;">Subscribe Now</a>
                    </div>
                </div>
            </div>
        </div>
    </main>
    </div>

    <!-- Modal -->
    <div class="modal fade" id="staticBackdrop1" data-bs-backdrop="static" data-bs-keyboard="false" tabindex="-1" aria-labelledby="staticBackdropLabel1" aria-hidden="true">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title" id="staticBackdropLabel1">Member Subscription</h5>
                    <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                </div>
                <div class="modal-body">
                    Are you sure you want to subscribe?
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-primary" style="background-color:black;" onclick="location.href='subscription.php?rank=Member'">Yes</button>
                    <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">No</button>
                </div>
            </div>
        </div>
    </div>
    <div class="modal fade" id="staticBackdrop2" data-bs-backdrop="static" data-bs-keyboard="false" tabindex="-1" aria-labelledby="staticBackdropLabel" aria-hidden="true">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title" id="staticBackdropLabel2">Enthusiast Subscription</h5>
                    <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                </div>
                <div class="modal-body">
                    Are you sure you want to subscribe?
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-primary" style="background-color:black;" onclick="location.href='subscription.php?rank=Enthusiast'">Yes</button>
                    <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">No</button>
                </div>
            </div>
        </div>
    </div>
    <div class="modal fade" id="staticBackdrop3" data-bs-backdrop="static" data-bs-keyboard="false" tabindex="-1" aria-labelledby="staticBackdropLabel" aria-hidden="true">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title" id="staticBackdropLabel2">Subscription Complete</h5>
                    <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                </div>
                <div class="modal-body">
                    Congratulations, you have now subscribed to GoodFood monthly subscription.
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Ok</button>
                </div>
            </div>
        </div>
    </div>

    <?php include "./footer.php" ?>

    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-OERcA2EqjJCMA+/3y+gxIOqMEjwtxJY7qPCqsdltbNJuaOe923+mo//f6V8Qbsw3" crossorigin="anonymous"></script>
</body>

</html>