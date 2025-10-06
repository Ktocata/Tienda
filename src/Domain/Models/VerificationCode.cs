namespace Tienda.src.Domain.Models
{
    public enum CodeType
    {
        EmailVerification,
        PasswordReset,
        PasswordChange
    }

    public class VerificationCode
    {

        /// Identificador único del código de verificación.
        public int Id { get; set; }


        /// Tipo de código de verificación.
        public required CodeType CodeType { get; set; }


        /// Código de verificación.
        public required string Code { get; set; }


        /// Cantidad de intentos realizados para usar el código (acumulativo).
        public int AttemptCount { get; set; } = 0;


        /// Fecha y hora de expiración del código de verificación (3 minutos por defecto).
        public required DateTime ExpiryDate { get; set; }


        /// Identificador único del usuario asociado al código de verificación.
        public required int UserId { get; set; }


        /// Fecha y hora en que se creó el código de verificación.
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}