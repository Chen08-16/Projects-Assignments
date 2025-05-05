<?php
session_start();
// Include config file
require_once "config.php";

// Define variables and initialize with empty values
$username = $email = $pnum = "";
// Processing form data when form is submitted
if ($_SERVER["REQUEST_METHOD"] == "POST") {
    if ($_POST['form-r']) {
        $sql1 = "SELECT * FROM user WHERE email = ? AND pnum = ?";
        if ($stmt = mysqli_prepare($link, $sql1)) {
            // Bind variables to the prepared statement as parameters
            mysqli_stmt_bind_param($stmt, "ss", $param_email, $param_pnum);
            // Set parameters
            $param_email = trim($_POST["email"]);
            $param_pnum = trim($_POST["pnum"]);
            // Attempt to execute the prepared statement
            if (mysqli_stmt_execute($stmt)) {
                $result = mysqli_stmt_get_result($stmt);
                if (mysqli_num_rows($result) != 1) {
                    $username = trim($_POST["username"]);
                    $email = trim($_POST["email"]);
                    $pnum = trim($_POST["pnum"]);
                    $sql = "INSERT INTO user (username, email, pnum, password, subscription) VALUES (?, ?, ?, ?, ?)";
                    if ($stmt = mysqli_prepare($link, $sql)) {
                        // Bind variables to the prepared statement as parameters
                        mysqli_stmt_bind_param($stmt, "sssss", $param_username, $param_email, $param_pnum, trim($_POST["password"]), $param_sub); // statement, "string string string"

                        // Set parameters
                        $param_username = $username;
                        $param_email = $email;
                        $param_pnum = $pnum;
                        $param_sub = "Normal";

                        // Attempt to execute the prepared statement
                        if (mysqli_stmt_execute($stmt)) {
                            $sql2 = "SELECT * FROM user WHERE email = ? AND pnum = ?";
                            if ($stmt = mysqli_prepare($link, $sql2)) {
                                // Bind variables to the prepared statement as parameters
                                mysqli_stmt_bind_param($stmt, "ss", trim($_POST["email"]), trim($_POST["pnum"]));
                                // Set parameters
                                // Attempt to execute the prepared statement
                                if (mysqli_stmt_execute($stmt)) {
                                    $result = mysqli_stmt_get_result($stmt);
                                    if (mysqli_num_rows($result) == 1) {
                                        $row = mysqli_fetch_assoc($result);
                                        $_SESSION['id'] = $row['id'];
                                        $_SESSION['username'] = $row['username'];
                                        $_SESSION['rank'] = $row['subscription'];
                                        // Records created successfully. Redirect to landing page
                                        header("location: index.php");
                                    } else {
                                        header("location: error.php");
                                        exit();
                                    }
                                }
                            }
                        }

                        // Close statement
                        mysqli_stmt_close($stmt);
                    }

                    // Close connection
                    mysqli_close($link);
                } else {
                    header("location: register.php?reg_error=1");
                    exit();
                }
            }
        }
    } elseif ($_POST['form-l']) {

        $sql = "SELECT * FROM user WHERE email = ? AND password = ?";
        if ($stmt = mysqli_prepare($link, $sql)) {
            // Bind variables to the prepared statement as parameters
            mysqli_stmt_bind_param($stmt, "ss", $param_email, trim($_POST["l-password"]));
            // Set parameters
            $param_email = trim($_POST["l-email"]);
            // Attempt to execute the prepared statement
            if (mysqli_stmt_execute($stmt)) {
                $result = mysqli_stmt_get_result($stmt);
                if (mysqli_num_rows($result) == 1) {
                    $row = mysqli_fetch_assoc($result);
                    $_SESSION['id'] = $row['id'];
                    $_SESSION['username'] = $row['username'];
                    $_SESSION['rank'] = $row['subscription'];
                    header("location: index.php");
                } else {
                    header("location: register.php?log_error=1");
                    exit();
                }
            }
        }
    }
}
?>


<!DOCTYPE html>
<html class="register-bg" lang="en">

<head>
    <meta charset="UTF-8">
    <link rel="stylesheet" href="style.css">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.2.1/css/all.min.css" integrity="sha512-MV7K8+y+gLIBoVD59lQIYicR65iaqukzvf/nwasF0nqhPay5w/9lJmVM2hMDcnK1OnMGCdVK+iQrJ7lzPJQd1w==" crossorigin="anonymous" referrerpolicy="no-referrer" />
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p" crossorigin="anonymous"></script>
    <title>Sign in</title>
</head>

<body style="background-image:url('../GoodFood/images/registerbg.jpg'); margin-top:30px;">
    <div class="register-header">
        <nav class="navbar navbar-expand-lg bg-white sticky-top navbar-light p-3 shadow-sm">
            <div class="container">
                <a class="navbar-brand" href="index.php"><i class="fa-solid fa-shop me-2"></i><strong>GOOD FOOD</strong></a>
                <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNavDropdown" aria-controls="navbarNavDropdown" aria-expanded="false" aria-label="Toggle navigation">
                    <span class="navbar-toggler-icon"></span>
                </button>

                <ul class="navbar-nav ms-auto ">
                    <li class="nav-item">
                        <a class="nav-link mx-2 text-uppercase active" aria-current="page" href="index.php">Home</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link mx-2 text-uppercase" href="shop.php">Shop</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link mx-2 text-uppercase" href="articles.php">Articles</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link mx-2 text-uppercase" href="articles.php">Events</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link mx-2 text-uppercase" href="aboutus.php">About Us</a>
                    </li>
                </ul>
                <ul class="navbar-nav ms-auto ">
                    <li class="nav-item">
                        <a class="nav-link mx-2 text-uppercase" href="register.php"><i class="fa-solid fa-circle-user me-1"></i> Sign In</a>
                    </li>
                </ul>
            </div>
        </nav>
    </div>

    <?php if (isset($_GET['reg_error'])) {
        echo '<div class="signContainer right-panel-active" id="signContainer">';
    } elseif (!isset($_GET['reg_error'])) {
        echo '<div class="signContainer" id="signContainer">';
    }  ?>

    <div class="form-signContainer sign-up-signContainer">
        <form action="<?php echo htmlspecialchars($_SERVER["PHP_SELF"]); ?>" method="post">
            <h1>Create Account</h1>
            <br>
            <input type="text" name="username" id="username" placeholder="Username" required />
            <input type="email" name="email" id="email" placeholder="Email" required />
            <input type="text" name="pnum" id="pnum" placeholder="Phone No." required />
            <input type="password" name="password" id="password" placeholder="Password" required />
            <input type="password" style="margin-bottom:15px;" name="cpassword" id="cpassword" placeholder="Confirm Password" required />
            <?php if (isset($_GET['reg_error'])) {
                echo '<a style="color:red;">User already exist! Please try again.</a>';
            } ?>
            <button type="submit" value="submit" name="form-r">Sign Up</button>
        </form>
    </div>
    <div class="form-signContainer sign-in-signContainer">
        <form action="<?php echo htmlspecialchars($_SERVER["PHP_SELF"]); ?>" method="post">
            <h1>Sign in</h1>
            <input type="email" name="l-email" placeholder="Email" required />
            <input type="password" name="l-password" placeholder="Password" required />
            <a></a>
            <?php if (isset($_GET['log_error'])) {
                echo '<a style="color:red;">Sign in Failed! Please try again.</a>';
            } ?>
            <button type="submit" value="submit" name="form-l">Sign In</button>
        </form>
    </div>
    <div class="signContainer-overlay-signContainer">
        <div class="signContainer-overlay">
            <div class="signContainer-overlay-panel signContainer-overlay-left">
                <h1>Welcome Back!</h1>
                <p>To keep connected with us please login with your personal info</p>
                <button class="ghost" id="signIn">Sign In</button>
            </div>
            <div class="signContainer-overlay-panel signContainer-overlay-right">
                <h1>New here?</h1>
                <p>Enter your personal details and start your journey with us</p>
                <button class="ghost" id="signUp">Sign Up</button>
            </div>
        </div>
    </div>
    </div>

</body>


<script>
    const signUpButton = document.getElementById('signUp');
    const signInButton = document.getElementById('signIn');
    const signContainer = document.getElementById('signContainer');

    signUpButton.addEventListener('click', () => {
        signContainer.classList.add("right-panel-active");
    });

    signInButton.addEventListener('click', () => {
        signContainer.classList.remove("right-panel-active");
    });
</script>

<script>
    var password = document.getElementById("password"),
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