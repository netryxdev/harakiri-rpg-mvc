namespace harakiri_rpg.Util
{
    public static class Messages
    {
        public static class Error
        {
            public const string GENERIC = "Um erro ocorreu, tente novamente mais tarde";
            public const string OPERATION_FAILED = "Um erro ocorreu ao realizar a operação";
            public const string DATA_LOADING_FAILED = "Um erro ocorreu ao carregar os dados";
            public const string NOT_FOUND = "Registro não encontrado";
            public static string REQUIRED(string field) => $"O campo de {field} é obrigatório";
            public static string INVALID(string field) => $"O campo de {field} é inválido";
            public static string INVALID_LENGTH(string field, int min, int max) => $"O campo de {field} deve ter entre {min} e {max} caracteres";
            public static string INVALID_MIN_LENGTH(string field, int min) => $"O campo de {field} deve ter no mínimo {min} caracteres";
            public static string INVALID_MAX_LENGTH(string field, int max) => $"O campo de {field} deve ter no máximo {max} caracteres";
            public static string INVALID_MIN_VALUE(string field, decimal min) => $"O campo de {field} deve ser no mínimo {min}";
            public static string INVALID_MAX_VALUE(string field, decimal max) => $"O campo de {field} deve ser no máximo {max}";
            public static string INVALID_FORMAT(string field) => $"O campo de {field} está em um formato inválido";

        }

        public static class Success
        {
            public const string DATA_SAVED = "Dados salvos com sucesso";
        }
    }
}
