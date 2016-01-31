using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DotNet_Utilities;

namespace Ovjust.UnitTest.CryptionSignature
{
    [TestClass]
    public class RsaTest
    {
        string keyPublic1 = "AAAAB3NzaC1yc2EAAAABJQAAAQEAtkj8HTOfNyxh1JQbCIZmH6R6hA0EbQBL7ut3B9CM2F2owvooe1uD4vKdI+121ewoAjyq6/GNT+uEAl3iJ3I2uEJHplBUYodw3hV0p4dJ9JVmLV+kAFbgCoGU8t7CDm6bN0bnF7eoCcM9yHfqE1EwJij5CYTj/Y2ebSpBfNbSdZ8Xe0HKuaYCybxrHn+mwMzX7KgZYHcrkhnqlsileBIFRTaM5gurm6/IN4mNTJ3XB6wTDhDuX+c4ilR0x+/LgG0arwE8X5HsDxYS5Z83zPrhhcN6z48cAkl3Fi2GVTMa+x3EXtEC1t8Lv//NaF7b2O7mC74Z+0FGzyTrzMgAK3S7vw==";
        string keyPrivate1 = @"3OIO+ONR6mSTKqA5qlyi4VrcaawQnYnKzpIUIMXffAYaqrYjJ44ZtkV7/QlteMvS
nAqUTsKPxldTirmgDrIenSsFRZyEshUqrqFJ22GzgsmvBSb4HztWGDuKU9s6+snT
KkFj1pF9bOpvt+IPw5IVglAffJ6Ysn/mcY91EwLBWWxljul6Y3am8Us8YV+pQZuU
F3ILJQ2B7K8nNTEP0RoImPNZAShXlh2nnvGL0jlgf3INZAcLICZaNKnepwSRnsZh
YpQfYFwj3TGUdYsjsSZhpR9eNia3oNAZgLUX4VSthYmG7E+WfrLVt6YGnin4dFC9
RH4WGuZjfbVP1QTTQ5jwJLXggB7uH1i275wRPHfW/x4om6A8BQ+cXtJBoIkIGZSr
0OTFxXPw/B89zDYc1vIP2cbw3tqUaD7NvI8BKwjtiVU+ZBeTPhRpTKQWV0vb29X4
PO4aFsshec+mE+sJAOj/zbgb6RM1v9DNBSL5NP0XXomy+R+VAjPKqgANhl2xRznz
08o1Hb4XoVm0MY3UtuuY/QXjzDsGmNvkdJpWCLD/xFV22QJs5Hq8G+p66U48J+yM
G6J+PeTBIsaidT6adlN0Trj/L6Q8YO47JfyTsg9VnSnsuaXsNH5+EhTvjCxZSbsT
14+ostcoQJEAG8+t3sCGl3e/cDhTeyDDFOwI3oAybzAFaWJHSJ6UIiKXMrFcIhJJ
hBEhG0yC7wdIObDfl8KZ6K/WgYU0vICdVvJNGjOQwK0zPWd9QUw57zzo4IKlxV/e
w/4+MKmPwdQcxJ4bJ7rn6RHsZQwsfqRBTrZrzyhY+hC7/FnP/6NGeqJXq+/LeoE7
Jw+lEL2oabnZFGjRnOidc9b5KkG+uR4tJxhyTqZeZUTN7rRxMKu8kmD4ANipr3ef";
        string keyPublic2 = "AAAAB3NzaC1yc2EAAAADAQABAAABAQDgfQnIdhV7DxoPogjtQ83OpM4azK101xugCPdx0myxWDC+P5ZYVRs5t00f9f+7E7c3+k4SjkIO5+nyzoGwmXoX6o/x6xvesDGb0KrDNxZmuBcpR/FsSR9Wf9p9k2TvmdXrWQJiN1VfUpR4yukCNi1WSNeYb5g6mC4J4H3cZ3MKTW4itI9glBvY6kSrfHnkAhROAMKV8XWB6LLXJzpkqyFkEirR8NOSAs9sFKxQ0akTbDrTVCMlG8gNxmMNajN3G5Pp40leubwEsFrS2LIHOubiIJUXOB/tAQOS6CHdtqGGJz9Aib6c9yIISESHwp15nwJ3mEYZh567UuB723h+JeHT";
        string keyPrivate2 = @"
MIIEogIBAAKCAQEA4H0JyHYVew8aD6II7UPNzqTOGsytdNcboAj3cdJssVgwvj+W
WFUbObdNH/X/uxO3N/pOEo5CDufp8s6BsJl6F+qP8esb3rAxm9CqwzcWZrgXKUfx
bEkfVn/afZNk75nV61kCYjdVX1KUeMrpAjYtVkjXmG+YOpguCeB93GdzCk1uIrSP
YJQb2OpEq3x55AIUTgDClfF1geiy1yc6ZKshZBIq0fDTkgLPbBSsUNGpE2w601Qj
JRvIDcZjDWozdxuT6eNJXrm8BLBa0tiyBzrm4iCVFzgf7QEDkugh3bahhic/QIm+
nPciCEhEh8KdeZ8Cd5hGGYeeu1Lge9t4fiXh0wIDAQABAoIBAFMKjfrki4+pB3fu
9aRnJ5OgbUmGm0eUZvitOHOXZnO37tgBh6kHWnngL5x6EG5wnZ8MbaL5ksAW0/jo
oRrluz9rmnHgCcA3pzI/X1u1XgkDYjX4Eft/lSMXSoiXZIgpfPOBSptwYplPX/LL
BKS3y8+WRIJ0DXjnYGhw7b4BWpHdXz4d3cb1JsfgTY1JMWusjwJ054rEAXBQbpyW
nVqot4rXIQv9XPRVtcx3hsB4xgjyZEypnw/9G5A+0y27eWwgWjFNrK7HgX5O/6E/
yHiWStM7RGxCHoJNfMT199VRw/8rfjTH1P03b7BKX0/ts85LmKFZb5PwZogbH+Zc
Py+w1ZECgYEA+IB9mEslOuzblC/EW7B7r97qh8pbxlGndpdgm7sQ14otR8vsudDn
H7c4GEtxJMvxjCr71sOsOCoEVAARFwodvxWA79a1mAyvfUbMKjs7fDcV9MLJk0NN
smWrGLFd8t7q8RH9BcmVJouh1sTg4OHJTFdMsWXqLHJ99YutiAlrmrkCgYEA50MP
Ra6KKD4K2geYqeBgsoXq/M1tR9OH8bfb40F45XxDprR4JGxA6HaZEUJ4XaeUOUOo
lkgnaXrqsDAitKCsXr5bokXLQ0fG727DLMHiTJE7hYYL3v4oSWOypFXMM9rIeLav
ghrF0LOiU0DLy9zOjX4o/5rEpllqBXWMKzCgqusCgYBKPjlH0suguzsvHsZPjn6l
oLf5MeARdDvQFpHqdQ0nGEVG+goTyfIDa736pC99iuDzu7PaCkPd08/POOXiOEeC
223WOhOvBbs4dnpw85lmFx8cLUYEFUuVTQK9MeCbuzX+KB2sKPnCtlz3yYJWLZ7y
i/KB3a0E8n/naH/D8OyRIQKBgDuDDU4QQWtjs+UxqT6mCBxIzBTsRGAEdmpktwg/
U/4yQTKIJJay6O0pf/BqG5F2S3WFDMBHpyTExdo7OOMkqdbjw675qPoSYYZCCaXd
6v9rLFcLDMkAvJtONa2GirsZZRdzY6zmeNthLref6BH5K4pL2f8U8+AfCGKJQl3m
8KGrAoGAazVdjq7m+u21tTUNRPMpKmGSxrgesGwjpTS5V8B2sIckt5e+QbkA2dkt
QfPnMpeG5+E2/incO1i4fWvopDDvkE12XsnS+X8GmE/wN378HHsquxpm5nHpxegX
QipTjnvJ5PGVFKeOUdT0Uh2ipaEbB8GqvFS74daAc9kS2JVYf2Y=";

        [TestMethod]
        public void TestCryption()
        {
            var keyPrivate = keyPrivate1;
            var keyPublic = keyPublic1;
            string strIn = "test中国国";
            string strOut = null;
            RSACryption rsa = new RSACryption();



            rsa.RSAKey(out keyPrivate,out keyPublic);
           
           strOut= rsa.RSAEncrypt(keyPublic,strIn);

           var strInNew = rsa.RSADecrypt(keyPrivate, strOut);
        }


        [TestMethod]
        public void TestSignature()
        {
            var keyPrivate = keyPrivate1;
            var keyPublic = keyPublic1;
            string strIn = "test中国国";
            string strOut = null;
            RSACryption rsa = new RSACryption();
            var b3 = rsa.GetHash("test中国国test中国国test中国国test中国国test中国国test中国国test中国国test中国国test中国国test中国国test中国国test中国国test中国国test中国国test中国国test中国国test中国国test中国国test中国国test中国国", ref strIn);


            rsa.RSAKey(out keyPrivate, out keyPublic);

            var b1 = rsa.SignatureFormatter(keyPrivate, strIn, ref strOut);
            var b2 = rsa.SignatureDeformatter(keyPublic, strIn,  strOut);

        }
    }
}
