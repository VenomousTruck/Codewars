// Welcome!

public static class Kata {
    public static string Greet(string language) {
        string[] languages = { "english", "czech", "danish", "dutch", 
            "estonian", "finnish", "flemish", "french", 
            "german", "irish", "italian", "latvian", 
            "lithuanian", "polish", "spanish", "swedish", 
            "welsh" };
        string[] welcomes = { "Welcome", "Vitejte", "Velkomst", "Welkom",
            "Tere tulemast", "Tervetuloa", "Welgekomen", "Bienvenue", 
            "Willkommen", "Failte", "Benvenuto", "Gaidits", 
            "Laukiamas", "Witamy", "Bienvenido", "Valkommen", 
            "Croeso" };

        for (int i = 0; i < languages.Length; i++) {
            if (languages[i] == language)
                return welcomes[i];
        }
        return "Welcome";
    }
}