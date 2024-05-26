

//Klasa Logger:
//    Zmienna nextLogger

//    Funkcja SetNextLogger(next):
//        Ustaw nextLogger na next

//    Funkcja LogMessage(level, message):
//        Jeśli CanHandle(level):
//            Wywołaj Write(message)
//        Inaczej jeśli nextLogger nie jest pusty:
//            Wywołaj nextLogger.LogMessage(level, message)

//    Abstrakcyjna funkcja CanHandle(level)
//    Abstrakcyjna funkcja Write(message)

//Klasa InfoLogger dziedziczy z Logger:
//    Funkcja CanHandle(level):
//        Zwróć prawda jeśli level == INFO

//    Funkcja Write(message):
//        Wypisz "INFO: " + message

//Klasa WarningLogger dziedziczy z Logger:
//    Funkcja CanHandle(level):
//        Zwróć prawda jeśli level == WARNING

//    Funkcja Write(message):
//        Wypisz "WARNING: " + message

//Klasa ErrorLogger dziedziczy z Logger:
//    Funkcja CanHandle(level):
//        Zwróć prawda jeśli level == ERROR

//    Funkcja Write(message):
//        Wypisz "ERROR: " + message

//Funkcja główna:
//    Stwórz logger infoLogger jako InfoLogger
//    Stwórz logger warningLogger jako WarningLogger
//    Stwórz logger errorLogger jako ErrorLogger

//    Wywołaj infoLogger.SetNextLogger(warningLogger)
//    Wywołaj warningLogger.SetNextLogger(errorLogger)

//    Ustaw loggerChain na infoLogger

//    Wywołaj loggerChain.LogMessage(INFO, "To jest wiadomość informacyjna.")
//    Wywołaj loggerChain.LogMessage(WARNING, "To jest wiadomość ostrzegawcza.")
//    Wywołaj loggerChain.LogMessage(ERROR, "To jest wiadomość o błędzie.")
//}
//}
