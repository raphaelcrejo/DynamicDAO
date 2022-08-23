using System.Data;

namespace DynamicDAO.Mapper
{
    /// <summary>
    /// Marca os elementos utilizados como parâmetros nas queries e/ou stored procedures. Essa classe não pode ser herdada.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
    public class ParameterAttribute : Attribute
    {
        #region Public Properties

        private string propertyName;
        private string parameterName;
        private ParameterDirection direction;

        /// <summary>
        /// Nome da propriedade da entidade, POCO ou DTO.
        /// </summary>
        public virtual string PropertyName
        {
            get => propertyName;
            set => propertyName = value;
        }

        /// <summary>
        /// Nome do parâmetro na stored procedure ou query.
        /// </summary>
        public virtual string ParameterName
        {
            get => parameterName;
            set => parameterName = value;
        }

        /// <summary>
        /// Direção do parâmetro na stored procedure ou query (Input, Output, InputOutput, ReturnValue).
        /// </summary>
        public virtual ParameterDirection Direction
        {
            get => direction;
            set => direction = value;
        }

        #endregion Public Properties

        #region Constructors

        /// <summary>
        /// Inicializa uma nova instância da classe <see cref="ParameterAttribute"/> com propriedades padrão.
        /// </summary>
        /// <param name="propertyName">Nome da propriedade da entidade, POCO ou DTO.</param>
        /// <param name="parameterName">Nome do parâmetro na stored procedure ou query.</param>
        /// <param name="parameterDirection">Direção do parâmetro na stored procedure ou query (Input, Output, InputOutput, ReturnValue).</param>
        public ParameterAttribute(string propertyName, string parameterName, ParameterDirection parameterDirection)
        {
            this.propertyName = propertyName;
            this.parameterName = parameterName;
            this.direction = parameterDirection;
        }

        #endregion Constructors
    }
}
