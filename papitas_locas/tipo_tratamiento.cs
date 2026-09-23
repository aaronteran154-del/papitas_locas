using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaOdontologico.Models
{
    [Table("especialidades")]
    public class Especialidad
    {
        [Key]
        [Column("id_especialidad")]
        public int IdEspecialidad { get; set; }

        [Required]
        [MaxLength(50)]
        [Column("nombre_especialidad")]
        public string NombreEspecialidad { get; set; } = string.Empty;

        [MaxLength(200)]
        [Column("descripcion")]
        public string? Descripcion { get; set; }
    }

    [Table("pacientes")]
    public class Paciente
    {
        [Key]
        [Column("id_paciente")]
        public int IdPaciente { get; set; }

        [Required]
        [MaxLength(10)]
        [Column("dni")]
        public string Dni { get; set; } = string.Empty;

        [Required]
        [MaxLength(50)]
        [Column("nombres")]
        public string Nombres { get; set; } = string.Empty;

        [Required]
        [MaxLength(50)]
        [Column("apellidos")]
        public string Apellidos { get; set; } = string.Empty;

        [Required]
        [Column("fecha_nacimiento")]
        public DateTime FechaNacimiento { get; set; }

        [Required]
        [MaxLength(100)]
        [EmailAddress]
        [Column("email")]
        public string Email { get; set; } = string.Empty;

        [MaxLength(15)]
        [Column("telefono")]
        public string? Telefono { get; set; }
    }

    [Table("consultorios")]
    public class Consultorio
    {
        [Key]
        [Column("id_consultorio")]
        public int IdConsultorio { get; set; }

        [Required]
        [MaxLength(10)]
        [Column("numero_sala")]
        public string NumeroSala { get; set; } = string.Empty;

        [Required]
        [Column("piso")]
        public int Piso { get; set; }

        [MaxLength(100)]
        [Column("equipamiento_principal")]
        public string? EquipamientoPrincipal { get; set; }
    }

    [Table("tratamientos")]
    public class Tratamiento
    {
        [Key]
        [Column("id_tratamiento")]
        public int IdTratamiento { get; set; }

        [Required]
        [MaxLength(100)]
        [Column("nombre_tratamiento")]
        public string NombreTratamiento { get; set; } = string.Empty;

        [Required]
        [Column("costo_base", TypeName = "decimal(10,2)")]
        public decimal CostoBase { get; set; }

        [Required]
        [Column("duracion_estimada_minutos")]
        public int DuracionEstimadaMinutos { get; set; }
    }
}