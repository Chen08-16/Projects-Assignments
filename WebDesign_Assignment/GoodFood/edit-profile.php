<?php
session_start();

require_once "config.php";

$sql = "SELECT * FROM user WHERE id = '" . $_SESSION['id'] . "'";
$result = $link->query($sql);
$row = $result->fetch_assoc();

if (isset($_GET['delete']) && $_GET['delete'] == 1){
    // Prepare a delete statement
    $sqlDelete = "DELETE FROM user WHERE id = ?";
    
    if($stmt0 = mysqli_prepare($link, $sqlDelete)){
        // Bind variables to the prepared statement as parameters
        mysqli_stmt_bind_param($stmt0, "i", $param_id);
        
        // Set parameters
        $param_id = $_SESSION["id"];
        
        // Attempt to execute the prepared statement
        if(mysqli_stmt_execute($stmt0)){
            // Records deleted successfully. Redirect to landing page
            header("location: logout.php");
        } else{
            echo "Oops! Something went wrong. Please try again later.";
        }
    }
     
    // Close statement
    mysqli_stmt_close($stmt);
    
    // Close connection
    mysqli_close($link);
} 

// Processing form data when form is submitted
if ($_SERVER['REQUEST_METHOD'] === 'POST') {
    // Get hidden input value
    $id = $_SESSION['id'];

    if (empty($_POST["username"])) {
        $username = $row['username'];
    } else {
        $username = trim($_POST["username"]);
    }
    if (empty($_POST["pnum"])) {
        $pnum = $row['pnum'];
    } else {
        $pnum = trim($_POST["pnum"]);
    }
    if (empty($_POST["email"])) {
        $email = $row['email'];
    } else {
        $email = trim($_POST["email"]);
    }
    if (empty($_POST["address"])) {
        $address = $row['address'];
    } else {
        $address = trim($_POST["address"]);
    }
    if (empty($_POST["bio"])) {
        $bio = $row['bio'];
    } else {
        $bio = $_POST["bio"];
    }
    if (!empty($_POST["oldpass"]) && !empty($_POST["newpass"]) && !empty($_POST["cpass"])) {
        $sqlCheck = "SELECT * FROM user WHERE id=? AND password=?";
        if ($stmt = mysqli_prepare($link, $sqlCheck)) {
            // Bind variables to the prepared statement as parameters
            mysqli_stmt_bind_param($stmt, "is", $param_id, $_POST["oldpass"]);
            // Set parameters
            $param_id = $id;
            // Attempt to execute the prepared statement
            if (mysqli_stmt_execute($stmt)) {
                $resultCheck = mysqli_stmt_get_result($stmt);
                if (mysqli_num_rows($resultCheck) == 1) {
                    $sqlUpdatePass = "UPDATE user SET password=? WHERE id=?";
                    if ($stmt2 = mysqli_prepare($link, $sqlUpdatePass)) {
                        mysqli_stmt_bind_param($stmt2, "si", $_POST['newpass'], $param_id);
                        // Set parameters
                        $param_id = $id;

                        // Attempt to execute the prepared statement
                        if (mysqli_stmt_execute($stmt2)) {
                            $sqlUpdate = "UPDATE user SET username=?, pnum=?,email=?,address=?,bio=? WHERE id=?";

                            if ($stmt3 = mysqli_prepare($link, $sqlUpdate)) {

                                mysqli_stmt_bind_param($stmt3, "sssssi", $param_name, $param_pnum, $param_email, $param_address, $param_bio, $param_id);

                                // Set parameters
                                $param_name = $username;
                                $param_pnum = $pnum;
                                $param_email = $email;
                                $param_address = $address;
                                $param_bio = $bio;
                                $param_id = $id;

                                // Attempt to execute the prepared statement
                                if (mysqli_stmt_execute($stmt3)) {
                                    // Records updated successfully. Redirect to landing page
                                    header("location: edit-profile.php?pass=1");
                                    exit();
                                } else {
                                    header("location: edit-profile.php?pass=2");
                                }
                            }
                            // Close statement
                            mysqli_stmt_close($stmt3);
                            // Close connection
                            mysqli_close($link);
                        } else {
                            echo "Oops! Something went wrong. Please try again later.";
                        }
                    }
                } else {
                    header("location: edit-profile.php?pass=0");
                    exit();
                }
            }
        }
    } else {
        $sqlUpdate = "UPDATE user SET username=?, pnum=?,email=?,address=?,bio=? WHERE id=?";

        if ($stmt = mysqli_prepare($link, $sqlUpdate)) {

            mysqli_stmt_bind_param($stmt, "sssssi", $param_name, $param_pnum, $param_email, $param_address, $param_bio, $param_id);

            // Set parameters
            $param_name = $username;
            $param_pnum = $pnum;
            $param_email = $email;
            $param_address = $address;
            $param_bio = $bio;
            $param_id = $id;

            // Attempt to execute the prepared statement
            if (mysqli_stmt_execute($stmt)) {
                // Records updated successfully. Redirect to landing page
                header("location: edit-profile.php?update=1");
                exit();
            } else {
                echo "Oops! Something went wrong. Please try again later.";
            }
        }
        // Close statement
        mysqli_stmt_close($stmt);
        // Close connection
        mysqli_close($link);
    }
}
?>
<?php 
        if(isset($_GET["update"]) && $_GET["update"]=1){
            echo "<script>alert('Profile successfully updated!');</script>";
        }
        if(isset($_GET["pass"]) && $_GET["pass"]==1){
            echo "<script>alert('Information successfully updated!');</script>";
        }
        if(isset($_GET["pass"]) && $_GET["pass"]==0){
            echo "<script>alert('Failed to update profile! Due to incorrect current password');</script>";
        }
    ?>
<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.2.1/css/all.min.css" integrity="sha512-MV7K8+y+gLIBoVD59lQIYicR65iaqukzvf/nwasF0nqhPay5w/9lJmVM2hMDcnK1OnMGCdVK+iQrJ7lzPJQd1w==" crossorigin="anonymous" referrerpolicy="no-referrer" />
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p" crossorigin="anonymous"></script>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
    <script src="//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
    <link rel="stylesheet" href="style.css">
    <title>Account Page</title>
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

<body style="background-image:url(../GoodFood/images/bg.png);">
    <!--Main-->
    <?php
    if ($result->num_rows != 0) {
        echo '<div class="container" style="padding-top:100px;">
                    <div class="row flex-lg-nowrap">
                        <div class="col-12 col-lg-auto mb-3" style="width: 200px;">
                        </div>
                        <div class="col">
                            <div class="row">
                                <div class="col mb-3">
                                    <div class="card">
                                        <div class="card-body">
                                            <div class="e-profile">
                                                <div class="row">
                                                    <div class="col-12 col-sm-auto mb-3">
                                                    </div>
                                                    <div class="col d-flex flex-column flex-sm-row justify-content-between mb-3">
                                                        <div class="text-center text-sm-left mb-2 mb-sm-0">
                                                        </div>
                                                    </div>
                                                </div>
                                                <ul class="nav nav-tabs">
                                                    <li class="nav-item"><a href="" class="active nav-link">Settings</a></li>
                                                </ul>
                                                <div class="tab-content pt-3">
                                                    <div class="tab-pane active">
                                                        <form method="post" action="">
                                                            <div class="row">
                                                                <div class="col">
                                                                    <div class="row">
                                                                        <div class="col">
                                                                            <div class="form-group">
                                                                                <label>Username</label>
                                                                                <input class="form-control" type="text" name="username" placeholder="' . $row['username'] . '" value="">
                                                                            </div>
                                                                        </div>
                                                                        <div class="col">
                                                                            <div class="form-group">
                                                                                <label>Phone Number</label>
                                                                                <input class="form-control" type="text" name="pnum" placeholder="' . $row['pnum'] . '" value="">
                                                                            </div>
                                                                        </div>
                                                                    </div>
                                                                    <div class="row">
                                                                        <div class="col">
                                                                            <div class="form-group">
                                                                                <label>Email</label>
                                                                                <input class="form-control" type="text" name="email" placeholder="' . $row['email'] . '">
                                                                            </div>
                                                                        </div>
                                                                    </div>
                                                                    <div class="row">
                                                                        <div class="col mb-1">
                                                                            <div class="form-group">
                                                                                <label>Address</label>
                                                                                <textarea class="form-control" rows="5" name="address" placeholder="' . $row['address'] . '"></textarea>
                                                                            </div>
                                                                        </div>
                                                                    </div>
                                                                    <div class="row">
                                                                        <div class="col mb-1">
                                                                            <div class="form-group">
                                                                                <label>My Bio</label>
                                                                                <textarea class="form-control" rows="5" name="bio" placeholder="' . $row['bio'] . '"></textarea>
                                                                            </div>
                                                                        </div>
                                                                    </div>
                                                                </div>
                                                            </div>
                                                            <div class="row">
                                                                <div class="col">
                                                                    <div class="mb-2"><b>Change Password</b></div>
                                                                    <div class="row">
                                                                        <div class="col">
                                                                            <div class="form-group">
                                                                                <label>Current Password</label>
                                                                                <input class="form-control" name="oldpass" id="oldpass" type="password" placeholder="">
                                                                            </div>
                                                                        </div>
                                                                    </div>
                                                                    <div class="row">
                                                                        <div class="col">
                                                                            <div class="form-group">
                                                                                <label>New Password</label>
                                                                                <input class="form-control" name="newpass" id="newpassword" type="password" placeholder="">
                                                                            </div>
                                                                        </div>
                                                                    </div>
                                                                    <div class="row">
                                                                        <div class="col">
                                                                            <div class="form-group">
                                                                                <label>Confirm <span class="d-none d-xl-inline">Password</span></label>
                                                                                <input class="form-control" name="cpass" id="cpassword" type="password" placeholder="">
                                                                            </div>
                                                                        </div>
                                                                    </div>
                                                                </div>
                                                            </div>
                                                            <br>
                                                            <div class="row">
                                                                <div class="col d-flex justify-content-end">
                                                                    <a href="account.php" class="btn btn-primary" style="background-color:black; border-color:black;margin-right:20px;">Cancel</a>
                                                                    <button class="btn btn-primary" type="submit" style="background-color:black; border-color:black;">Save Changes</button>
                                                                </div>
                                                            </div>
                                                        </form>
            
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
            
                                <div class="col-12 col-md-3 mb-3">
                                    <div class="card">
                                        <div class="card-body">
                                            <h6 class="card-title font-weight-bold">Account Delete</h6>
                                            <p class="card-text">Permanently delete account</p>
                                            <a href="#" class="btn btn-primary" data-bs-toggle="modal" data-bs-target="#staticBackdropDelete" style="background-color:black; border-color:black;">Delete</a>
                                        </div>
                                    </div>
                                </div>
                            </div>
            
                        </div>
                    </div>
                </div>';
    }
    ?>

    <?php include "./footer.php" ?>

</body>
<div class="modal fade" id="staticBackdropDelete" data-bs-backdrop="static" data-bs-keyboard="false" tabindex="-1" aria-labelledby="staticBackdropLabel" aria-hidden="true">
  <div class="modal-dialog">
    <div class="modal-content">
      <div class="modal-header">
        <h5 class="modal-title" id="staticBackdropLabel">Delete Account Forever</h5>
        <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
      </div>
      <div class="modal-body">
        Are you sure you want to delete this account?
      </div>
      <div class="modal-footer">
        <button type="button" class="btn btn-primary" style="background-color:black;" onclick="location.href='edit-profile.php?delete=1'">Yes</button>
        <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">No</button>
      </div>
    </div>
  </div>
</div>

<script>
    var password = document.getElementById("newpassword"),
        confirm_password = document.getElementById("cpassword");

    function validatePassword() {
        if (password.value != confirm_password.value) {
            confirm_password.setCustomValidity("Passwords Don't Match");
        } else {
            confirm_password.setCustomValidity('');
        }
    }

    password.onchange = validatePassword;
    confirm_password.onkeyup = validatePassword;
</script>

</html>