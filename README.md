# GraphQLWithModelValidation
Data Annotated Model Support for HotChocolate

Test query
```graphql
{
  s2: sample(
    test: "1"
    count: -1
    obj: { count: -1, text: "12"}
    obj1: { count: 10, text: "123"}
    obj2: { count: -1, text: "12"}
  ) {
    count
    text
  }
}
```
