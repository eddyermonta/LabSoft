namespace LabSoft.DTOs
{
    public class ClienteResponseDTO
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }

        public DireccionResponseDTO Direccion { get; set; }
        public PreferenciaResponseDTO Preferencia { get; set; }
    }
}