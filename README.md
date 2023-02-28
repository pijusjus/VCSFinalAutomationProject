# VCSFinalAutomationProject Test Cases

## Scenario: User Registration

### Test Case: Register functionality

#### Prerequisites: 
     - Clear cache
     - URL: https://elektromarkt.lt/registracija

##### Steps:
     
      1. Navigate to the registration page
      2. Accept Cookies
      3. Enter First Name
      4. Enter Last Name
      5. Enter Email
      6. Enter Phone Number
      7. Enter Password
      8. Repeat Password
      9. Subscribe to news email
      10. Accept Terms and Conditions
      11. Click Continue
     
##### Expected Result: The account is successfully created.

#

## Scenario: User Login

### Test Case: User login functionality

#### Prerequisites:
      - Must have a created account
      - Cleared cache
      - URL: https://elektromarkt.lt/prisijungimas
      
##### Steps: 
      
      1. Navigate to the login page
      2. Enter Email
      3. Enter Password
      4. Click Login
     
##### Expected Result: The user has succesfully logged in.

#

## Scenario: Product Search

### Test Case: Product search functionality

#### Prerequisites: 
    - Cleared cache
    - URL: https://elektromarkt.lt/
    
##### Steps: 

      1. Click on the search field
      2. Input "iPhone"
      3. Click Search
      4. Find relevant search results to "iPhone"
      
##### Expected Result: The user has succesfully found a product.

#

## Scenario: Product Purchase

### Test Case: Product purchase functionality

#### Prerequisites: 
    - Cleared cache
    - Must have an account
    - Cleared the product basket before initiating the test
    - URL: https://elektromarkt.lt/
    
##### Steps: 

      1. Navigate to the page
      2. Accept Cookies
      3. Go to the login page
      4. Enter Email
      5. Enter Password
      6. Click Login
      7. Go to the landing page
      8. Mouse over "Prekiu Katalogas" dropdown menu
      9. Select any catalog
      10. Select Category
      11. Select Product
      12. Add to Cart
      13. Click to checkout
      14. Select Warranty plan
      15. Proceed to checkout
      16. Fill out shipping information
      17. Continue to payment method selection
      
      
      
##### Expected Result: The user has succesfully reached the payment method selection screen.
