using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AuctionSite.Models
{
    public class ListingViewModel
    {
        [Key]
        public int listingId { get; set; }

        //The name of the item to be sold
        public string listingName { get; set; }

        //The condition of the listed item (Used, New, Worn, Broken,)
        public string listItemCondition { get; set; }

        //Is able to be shipped to whoever buys
        public bool isShipping { get; set; }

        //The price that someone can spend to forgo the auction option and buy it immediatly
        [DataType(DataType.Currency)]
        public int listingBuyOutPrice { get; set; }

        //The price where the bidding starts
        [DataType(DataType.Currency)]
        public int lisingStartingPrice { get; set; }

        //The date that the listing was posted
        [DataType(DataType.Date)]
        public DateTime listingPostDate { get; set; }

        //The date that the listing automaticaly closes
        [DataType(DataType.Date)]
        public DateTime listingEndDate { get; set; }

        //The listing desciption to describe the product
        public string listingDescription { get; set; }

        //The category of the listing
        public string listingCategory { get; set; }

        //The url that calls the image for the listing
        [DataType(DataType.ImageUrl)]
        public string listingImageURL { get; set; }
    }
}
