﻿using OpenQA.Selenium;

namespace AcceptanceTests.Common.PageObject.Pages
{
    public static class LoginPage
    {
        public static By UsernameTextfield = By.CssSelector("#i0116");
        public static By PasswordField = By.XPath("//input[contains(@data-bind,'password')]");
        public static By Next = By.XPath("//input[contains(@data-bind,'Next') and (@value='Next')]");
        public static By SignIn = By.XPath("//input[contains(@data-bind,'SignIn') and (@value='Sign in')]");
        public static string SignInTitle = "Sign in to your account";
        public static By ReSignInButton(string username) => By.XPath($"//div[contains(text(), '{username}')]");
        public static By CurrentPassword = By.Id("currentPassword");
        public static By NewPassword = By.Id("newPassword");
        public static By ConfirmNewPassword = By.Id("confirmNewPassword");
        public static By SignInButtonAfterPasswordChange = By.Id("idSIButton9");
    }
}
