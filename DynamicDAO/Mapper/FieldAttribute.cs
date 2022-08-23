namespace DynamicDAO.Mapper
{
    /// <summary>
    /// Marca os elementos utilizados como receptores de dados das queries e/ou stored procedures. Essa classe não pode ser herdada.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
    public class FieldAttribute : Attribute
    {
        #region Public Properties

        private string propertyName;
        private string retrievedField;

        /// <summary>
        /// Nome do campo
        /// </summary>
        public virtual string PropertyName
        {
            get => propertyName;
            set => propertyName = value;
        }

        /// <summary>
        /// Campo retornado pela consulta
        /// </summary>
        public virtual string RetrievedField
        {
            get => retrievedField;
            set => retrievedField = value;
        }

        #endregion Public Properties

        #region Constructors

        /// <summary>
        /// Inicializa uma nova instância da classe <see cref="FieldAttribute"/> com propriedades padrão.
        /// </summary>
        /// <param name="propertyName">Nome da propriedade da entidade, POCO ou DTO.</param>
        /// <param name="retrievedField">Nome da coluna devolvida pela consulta.</param>
        public FieldAttribute(string propertyName, string retrievedField)
        {
            this.propertyName = propertyName;
            this.retrievedField = retrievedField;
        }

        #endregion Constructors
    }
}
