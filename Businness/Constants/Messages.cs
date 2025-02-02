﻿using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime ="Sistem bakımda";
        public static string ProductListed ="Ürünler listelendi";
        public static string ProductCountOfCategoryError = "categorideki ürün limitini aştınız";
        public static string ProductNameAlreadyExits = "bu isimde zaten başka bir ürün var";

        public static string CategoryLimitExceded = "kategori limiti aşıldığı içim ürün eklenemiyor.";
        public static string AuthorizationDenied = "Yetkiniz yok.";
        public static string UserRegistered = "Kayıt oldu.";
        public static string UserNotFound = "Kullanıcı bulunamadı.";
        public static string PasswordError="Parola hatası.";
        public static string SuccessfulLogin="Başarılı giriş.";
        public static string UserAlreadyExists = "Kullanıcı mevcut.";
        public static string AccessTokenCreated= "Token oluşturuldu.";
    }
}
