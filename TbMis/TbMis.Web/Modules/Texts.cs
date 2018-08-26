using Serenity;
using Serenity.Extensibility;

namespace TbMis
{
    [NestedLocalTexts]
    public static partial class Texts
    {
        public static class Db
        {
            public static class Administration
            {
                public static class Translation
                {
                    public static LocalText EntityPlural = "Translations";
                    public static LocalText Key = "Local Text Key";
                    public static LocalText SourceLanguage = "Source Language";
                    public static LocalText SourceText = "Effective Translation in Source Language";
                    public static LocalText TargetLanguage = "Target Language";
                    public static LocalText TargetText = "Effective Translation in Target Language";
                    public static LocalText CustomText = "User Translation in Target Language";
                    public static LocalText OverrideConfirmation = "Overwrite user translation with clicked text?";
                    public static LocalText SaveChangesButton = "保存修改";
                }
            }
        }

        public static class Forms
        {
            public static class Membership
            {
                public static class ChangePassword
                {
                    public static LocalText FormTitle = "修改密码";
                    public static LocalText SubmitButton = "修改密码";
                    public static LocalText Success = "密码修改成功.";
                }

                public static class ForgotPassword
                {
                    public static LocalText FormInfo = "Please enter the e-mail you used to signup.";
                    public static LocalText FormTitle = "忘记密码";
                    public static LocalText SubmitButton = "Reset My Password";
                    public static LocalText Success = "An e-mail with password reset instructions is sent to your e-mail address.";
                    public static LocalText BackToLogin = "I remember my password";
                }

                public static class ResetPassword
                {
                    public static LocalText EmailSubject = "Reset Your TbMis Password";
                    public static LocalText FormTitle = "Reset Password";
                    public static LocalText SubmitButton = "Reset Password";
                    public static LocalText Success = "Your password is changed. Please login with your new password.";
                    public static LocalText BackToLogin = "I remember my password. Don't reset it!";
                }

                public static class Login
                {
                    public static LocalText FormTitle = "欢迎进入南华大学教材管理系统";
                    public static LocalText SignInButton = "登录";
                    public static LocalText ForgotPassword = "忘记密码?";
                    public static LocalText SignUpButton = "创建新账户";
                    public static LocalText RememberMe = "记住我";
                    public static LocalText OR = "OR";
                    public static LocalText FacebookButton = "Sign in using Facebook";
                    public static LocalText GoogleButton = "Sign in using Google+";
                }

                public static class SignUp
                {
                    public static LocalText ActivateEmailSubject = "Activate Your TbMis Account";
                    public static LocalText ActivationCompleteMessage = "Your account is now activated. " + 
                        "Use the e-mail and password you used while signing up to login.";
                    public static LocalText FormInfo = "Enter your details to create a free account.";
                    public static LocalText FormTitle = "注册";
                    public static LocalText SubmitButton = "登录";
                    public static LocalText Success = "An e-mail with instructions to active your account is " + 
                        "sent to your e-mail address. Please check your e-mails.";

                    public static LocalText DisplayName = "Full Name";
                    public static LocalText Email = "E-mail";
                    public static LocalText ConfirmEmail = "Confirm Email";
                    public static LocalText Password = "Password";
                    public static LocalText ConfirmPassword = "Confirm Password";

                    public static LocalText AcceptTerms = "I agree to the terms";
                    public static LocalText BackToLogin = "I already have a membership";
                }
            }
        }

        public static class Navigation
        {
            public static LocalText LogoutLink = "注销";
            public static LocalText SiteTitle = "教材管理系统";
        }

        public static class Site
        {
            public static class AccessDenied
            {
                public static LocalText PageTitle = "Unauthorized Access";
                public static LocalText LackPermissions = "You don't have required permissions to access this page!";
                public static LocalText NotLoggedIn = "You need to be logged in to access this page!";
                public static LocalText ClickToChangeUser = "click here to login with another user...";
                public static LocalText ClickToLogin = "点击这里返回登录页面…";
            }

            public static class Dashboard
            {
                public static LocalText ContentDescription =
                    "a sample with random data (from free <em><a href = \"https://almsaeedstudio.com/\" target= \"_blank\">" +
                    "AdminLTE theme</a></em>)";
            }

            public static class BasicProgressDialog
            {
                public static LocalText CancelTitle = "Operation cancelled. Waiting for in progress calls to complete...";
                public static LocalText PleaseWait = "Please wait...";
            }

            public static class BulkServiceAction
            {
                public static LocalText AllHadErrorsFormat = "All {0} record(s) that are processed had errors!";
                public static LocalText AllSuccessFormat = "Finished processing on {0} record(s) with success.";
                public static LocalText ConfirmationFormat = "Perform this operation on {0} selected record(s)?";
                public static LocalText ErrorCount = "{0} error(s)";
                public static LocalText NothingToProcess = "Please select some records to process!";
                public static LocalText SomeHadErrorsFormat = "Finished processing on {0} record(s) with success. {1} record(s) had errors!";
                public static LocalText SuccessCount = "{0} done";
            }

            public static class UserDialog
            {
                public static LocalText EditPermissionsButton = "Edit Permissions";
                public static LocalText EditRolesButton = "Edit Roles";
            }

            public static class UserRoleDialog
            {
                public static LocalText DialogTitle = "Edit User Roles ({0})";
                public static LocalText SaveSuccess = "Updated user roles.";
            }

            public static class UserPermissionDialog
            {
                public static LocalText DialogTitle = "Edit User Permissions ({0})";
                public static LocalText SaveSuccess = "Updated user permissions.";
                public static LocalText Permission = "Permission";
                public static LocalText Grant = "Grant";
                public static LocalText Revoke = "Revoke";
            }

            public static class RolePermissionDialog
            {
                public static LocalText EditButton = "Edit Permissions";
                public static LocalText DialogTitle = "Edit Role Permissions ({0})";
                public static LocalText SaveSuccess = "Updated role permissions.";
            }

            public static class Layout
            {
                public static LocalText FooterCopyright = "Copyright (c) 2018.";
                public static LocalText FooterInfo = "南华大学";
                public static LocalText FooterRights = "All rights reserved.";
                public static LocalText GeneralSettings = "General Settings";
                public static LocalText Language = "Language";
                public static LocalText Theme = "Theme";
                public static LocalText ThemeBlack = "Black";
                public static LocalText ThemeBlackLight = "Black Light";
                public static LocalText ThemeBlue = "Blue";
                public static LocalText ThemeBlueLight = "Blue Light";
                public static LocalText ThemeGreen = "Green";
                public static LocalText ThemeGreenLight = "Green Light";
                public static LocalText ThemePurple = "Purple";
                public static LocalText ThemePurpleLight = "Purple Light";
                public static LocalText ThemeRed = "Red";
                public static LocalText ThemeRedLight = "Red Light";
                public static LocalText ThemeYellow = "Yellow";
                public static LocalText ThemeYellowLight = "Yellow Light";
            }

            public static class ValidationError
            {
                public static LocalText Title = "错误";
            }
        }

        public static partial class Validation
        {
            public static LocalText AuthenticationError = "用户名或密码无效!";
            public static LocalText CurrentPasswordMismatch = "您当前的密码无效!";
            public static LocalText MinRequiredPasswordLength = "密码输入长度过短 (min {0})!";
            public static LocalText InvalidResetToken = "您重置的密码无效或已过期!";
            public static LocalText InvalidActivateToken = "您的帐户激活无效或已过期!";
            public static LocalText CantFindUserWithEmail = "无法找到该电子邮件地址的用户!";
            public static LocalText EmailInUse = "存在此电子邮件的另一个用户!";
            public static LocalText EmailConfirm = "输入的电子邮件不匹配!";
            public static LocalText DeleteForeignKeyError = "无法删除记录. '{0}' 表有 " +
                "依赖于此的记录!";
            public static LocalText SavePrimaryKeyError = "无法保存记录. 还有另一条记录 {1} 值!";
        }
    }
}