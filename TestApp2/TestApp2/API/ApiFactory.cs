using Refit;

namespace TestApp2{
    public static class ApiFactory{
        public static IApi CreateClient(){
            return RestService.For<IApi>("https://api.punkapi.com/v2/");
        }
    }
}