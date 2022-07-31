namespace JsonConvert
{
    public class Converter<T>
        where T : class, new()
    {
        public T DeSerialize(string json)
        {
            T entity = (T)Activator.CreateInstance(typeof(T));
            var properties = typeof(T).GetProperties();
            foreach (var jsonProperty in json.Split(","))
            {
                string left = jsonProperty.Split(":")[0].Replace("\"", "");
                object right = jsonProperty.Split(":")[1].Replace("\"", "");
                var findedProperty = properties.SingleOrDefault(x => x.Name.ToLower() == left.ToLower());
                if (findedProperty != null)
                {
                    Type propertyType = findedProperty.PropertyType;
                    findedProperty.SetValue(entity, Convert.ChangeType(right,propertyType));
                }
            }
            return entity;
        }
    }
}
