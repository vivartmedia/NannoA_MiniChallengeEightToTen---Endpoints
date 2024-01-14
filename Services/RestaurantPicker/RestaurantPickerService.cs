
namespace NannoA_MiniChallengeEightToTen___Endpoints.Services.RestaurantPicker;

public class RestaurantPickerService : IRestaurantPickerService
{
    public string RestaurantPicker(string Enter_Number_1_or_2_or_3_Only)
    {
        int Rest_Category;
        if (int.TryParse(Enter_Number_1_or_2_or_3_Only, out Rest_Category))
        {
            string Selected_Rest_Category;
            string[] sub_Categry;

            if (Rest_Category == 1){
                Selected_Rest_Category = "1. Fast Food Restaurants";
                sub_Categry = new string[]
                {
                    "McDonalds", "Taco Bell", "Chili's", "Subway", "Pizza Hut",
                    "KFC", "Chipotle", "In-N-Out Burger", "Wendy's", "Burger King"
                };
            }
            else if (Rest_Category == 2){
                Selected_Rest_Category = "2. Asian Restaurants";
                sub_Categry = new string[]
                {
                    "Raw Suchi Bistro", "Phoenix Noodle House", "Sushi Garden", "Modesto Sukiyaki", "Thai House",
                    "Dynasty Garden", "Thailand Restaurant", "JP Asian Fusion", "Kimoto Sake and Sushi", "China Gate"
                };
            }
            else if (Rest_Category == 3){
                Selected_Rest_Category = "3. Latin American Restaurants";
                sub_Categry = new string[]
                {
                    "Guayabitos Restaurant", "El Rosal 2", "La Parrilla Mexican Restaurant", "La Morenita", "La Prrilla Mexian Restaurant",
                    "El Rosal", "Familia Juares's Restaurant", "Marcella's Restuarant", "Memo's Cocina & Tequila Bar", "La Reyna Mexican Resturant"
                };
            }else{
                return "Invalid Restaurant's category choice. Please enter 1, 2, or 3.";
            }
            int random_sub_Categry_Index = new Random().Next(0, sub_Categry.Length);
            string selected_sub_Categry = sub_Categry[random_sub_Categry_Index];
            return $"You selected: {Selected_Rest_Category}; I suggest you try this restuarant: {selected_sub_Categry}";
        }
        else{
            return "Invalid Restaurant's category choice. Please enter 1, 2, or 3.";
        }
    }
}
