Feature: Add to cart

  Scenario: Add to cart
    Given I am on the swag website
    Then I'm logging in
    When I'm adding to cart backpack
    Then I should see backpack in a cart
    When I'm adding to T-Shirt
    Then I should see T-Shirt in a cart
    Then I should close Chrome