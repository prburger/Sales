using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using v4.Models;

namespace v4.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            GetProducts("");
            ViewData["Message"] = "Sweet Deals - the house of value";
            var headers = Request.Headers.ToDictionary(k => k.Key, v => v.Value.ToString());
            return View();
        }

        public IActionResult Affiliate()
        {
            ViewData["Message"] = "Affiliate Marketing";
            GetProducts("");
            return View();
        }

        public IActionResult Refund()
        {
            ViewData["Message"] = "Our Refund Policy";
            return View();
        }

        public IActionResult Products(string category)
        {
            switch (category)
            {
                case "Accessories": Accessories(); break;
                case "Art/Photo/Music": Art(); break;
                case "Automotive": Auto(); break;
                case "Beauty": Beauty(); break;
                case "Books/Media": Books(); break;
                case "Business": Business(); break;
                case "Buying/Selling": Buying(); break;
                case "Careers": Careers(); break;
                case "Clothing/Apparel": Clothing(); break;
                case "Computers/Electronics": Computers(); break;
                case "Stores/Malls": Shops(); break;
                case "Education": Education(); break;
                case "Entertainment": Entertainment(); break;
                case "Family": Family(); break;
                case "Financial Services": Money(); break;
                case "Food/Drinks": Food(); break;
                case "Games/Toys": Games(); break;
                case "Gifts/Flowers": Gifts(); break;
                case "Health/Wellness": Health(); break;
                case "Home/Garden": Home(); break;
                case "Insurance": Insurance(); break;
                case "Legal": Legal(); break;
                case "Marketing": Marketing(); break;
                case "Non-Profit": NonProfit(); break;
                case "Online Services": Online(); break;
                case "Recreation/Leisure": Recreation(); break;
                case "Seasonal": Seasonal(); break;
                case "Sports/Fitness": Sports(); break;
                case "Telecommunications": Communications(); break;
                case "Travel": Travel(); break;

            }
            return View();
        }

        public void Accessories()
        {
            ViewBag.Category = "Accessories";
            ViewData["Message"] = "Handbags, Jewlery, Shoes";
            GetProducts((string)ViewBag.Category);
        }

        public void Education()
        {
            ViewBag.Category = "Education";
            ViewData["Message"] = "Children, College, Languages, Professional";
            GetProducts((string)ViewBag.Category);
        }

        public void Entertainment()
        {
            ViewBag.Category = "Entertainment";
            ViewData["Message"] = "Discounts, Events, Guides, Memorabilia, Mobile Entertainment, Party Goods";
            GetProducts((string)ViewBag.Category);
        }

        public void Family()
        {
            ViewBag.Category = "Family";
            ViewData["Message"] = "Babies, Children, Entertainment, Teens, Weddings";
            GetProducts((string)ViewBag.Category);
        }

        public void Money()
        {
            ViewBag.Category = "Financial Services";
            ViewData["Message"] = "Banking/Trading, Credit Cards, Credit Reporting and Repair, Investment, Mortgage Loans, Personal Loans, Real Estate Services, Tax Services";
            GetProducts((string)ViewBag.Category);
        }

        public void Food()
        {
            ViewBag.Category = "Food/Drinks";
            ViewData["Message"] = "Gourmet, Green, Groceries, Restaurants, Wine & Spirits";
            GetProducts((string)ViewBag.Category);
        }

        public void Games()
        {
            ViewBag.Category = "Games/Toys";
            ViewData["Message"] = "Electronic Games, Electronic Toys, Games, Toys";
            GetProducts((string)ViewBag.Category);
        }

        public void Gifts()
        {
            ViewBag.Category = "Gifts/Flowers";
            ViewData["Message"] = "Collectibles, Flowers, Gifts, Green, Greeting Cards";
            GetProducts((string)ViewBag.Category);
        }

        public void Health()
        {
            ViewBag.Category = "Health/Well-being";
            ViewData["Message"] = "Equipment, Green, Health Food, Nutritional Supplements, Pharmaceuticals, Self Help, Vision Care, Weight Loss, Wellness";
            GetProducts((string)ViewBag.Category);
        }

        public void Home()
        {
            ViewBag.Category = "Home/Garden";
            ViewData["Message"] = "Bed & Bath, Construction, Energy Saving, Furniture, Garden, Green, Home Appliances, Kitchen, Pets, Real Estate, Recycling, Utilities";
            GetProducts((string)ViewBag.Category);
        }

        public void Insurance()
        {
            ViewBag.Category = "Insurance";
            ViewData["Message"] = "Commercial, Personal Insurance";
            GetProducts((string)ViewBag.Category);
        }

        public void Legal()
        {
            ViewBag.Category = "Legal";
            ViewData["Message"] = "Legal Services";
            GetProducts((string)ViewBag.Category);
        }

        public void Marketing()
        {
            ViewBag.Category = "Marketing";
            ViewData["Message"] = "Business-to-Business, Network Marketing";
            GetProducts((string)ViewBag.Category);
        }

        public void NonProfit()
        {
            ViewBag.Category = "NonProfit";
            ViewData["Message"] = "Charitable Organizations, Fundraising";
            GetProducts((string)ViewBag.Category);
        }

        public void Online()
        {
            ViewBag.Category = "Online Services";
            ViewData["Message"] = "Blogs, Broadband, Domain Registrations, Email Marketing, Internet Service Providers, Search Engine, Web Design, Web Hosting/Servers, Web Tools";
            GetProducts((string)ViewBag.Category);
        }

        public void Recreation()
        {
            ViewBag.Category = "Recreation/Leisure";
            ViewData["Message"] = "Astrology, Betting/Gaming, Camping and Hiking, Communities, Green, Matchmaking, Outdoors";
            GetProducts((string)ViewBag.Category);
        }

        public void Seasonal()
        {
            ViewBag.Category = "Seasonal";
            ViewData["Message"] = "Autumn, Back to School, Black Friday/Cyber Monday, Christmas, Easter, Father's Day, Halloween, Mother's Day, New Year, Spring, Summer, Tax Season, Valentine's Day, Winter";
            GetProducts((string)ViewBag.Category);
        }

        public void Sports()
        {
            ViewBag.Category = "Sports";
            ViewData["Message"] = "Apparel, Collectibles and Memorabilia, Equipment, Exercise & Health, Golf, Professional Sports Organizations, Sports, Summer Sports, Water Sports, Winter Sports";
            GetProducts((string)ViewBag.Category);
        }

        public void Communications()
        {
            ViewBag.Category = "Telecommunications";
            ViewData["Message"] = "Online/Wireless, Phone Card Services, Telephone Services";
            GetProducts((string)ViewBag.Category);
        }

        public void Travel()
        {
            ViewBag.Category = "Travel";
            ViewData["Message"] = "Accessories, Air, Car, Green, Hotel, Luggage, Vacation";
            GetProducts((string)ViewBag.Category);
        }

        public void Art()
        {
            ViewBag.Category = "Art/Photo/Music";
            ViewData["Message"] = "Art, Music, Photography";
            GetProducts((string)ViewBag.Category);
        }

        public void Auto()
        {
            ViewBag.Category = "Automotive";
            ViewData["Message"] = "Cars & Trucks, Motorcycles, Parts & Accessories, Rentals, Tools and Supplies";
            GetProducts((string)ViewBag.Category);
        }

        public void Beauty()
        {
            ViewBag.Category = "Beauty";
            ViewData["Message"] = "Bath & Body, Cosmetics, Fragrances, Green";
            GetProducts((string)ViewBag.Category);
        }

        public void Books()
        {
            ViewBag.Category = "Books/Media";
            ViewData["Message"] = "Audio Books, Books, Magazines, News, Television, Videos/Movies";
            GetProducts((string)ViewBag.Category);
        }

        public void Business()
        {
            ViewBag.Category = "Business";
            ViewData["Message"] = "Business-to-Business, Marketing, Office, Productivity Tools, Travel";
            GetProducts((string)ViewBag.Category);
        }

        public void Buying()
        {
            ViewBag.Category = "Buying/Selling";
            ViewData["Message"] = "Auction, Classifieds, E-commerce Solutions/Providers, New/Used Goods";
            GetProducts((string)ViewBag.Category);
        }

        public void Careers()
        {
            ViewBag.Category = "Careers";
            ViewData["Message"] = "Employment, Military";
            GetProducts((string)ViewBag.Category);
        }

        public void Clothing()
        {
            ViewBag.Category = "Clothing/Apparel";
            ViewData["Message"] = "Children's, Green, Men's, Women's";
            GetProducts((string)ViewBag.Category);
        }

        public void Computers()
        {
            ViewBag.Category = "Computers/Electronics";
            ViewData["Message"] = "Computer HW, Computer SW, Computer Support, Consumer Electronics, Green, Peripherals";
            GetProducts((string)ViewBag.Category);
        }

        public void Shops()
        {
            ViewBag.Category = "Stores/Malls";
            ViewData["Message"] = "Departments stores and Virtual malls";
            GetProducts((string)ViewBag.Category);
        }

        private void GetProducts(string category)
        {
            List<Product> products = new List<Product>();

            if (products.Count == 0)
            {
                products.Add(new Product("Accessories", "Sexy Swimwear", "AmiClubWear", "http://www.kqzyfj.com/click-8333070-11087252", "/images/products/accessories/sexy swimwear.jpg", "This leading online retailer has fashionable club apparel, shoes & accessories for women of all ages.", 300, 250));
                products.Add(new Product("Accessories", "Laced in Leather", "AmiClubWear", "http://www.anrdoezrs.net/click-8333070-11136061", "/images/products/accessories/laced in leather.jpg", "Look just like your favorite celeberity in one simple shopping trip", 300, 250));
                products.Add(new Product("Accessories", "Sexy Shoes", "AmiClubWear", "http://www.kqzyfj.com/click-8333070-11897455", "/images/products/accessories/sexy heels.jpg", "Boots, Sandals, Pumps, High Heels, Women's Shoes, Summer Shoes, Prom Shoes, Formal Shoes, Thigh High Boots, Platform Knee High Boots, Sexy Boots, Platform Boots, Evening Shoes, Wedding Shoes, Party Shoes, Club Shoes, Club Dress Pumps and Sandals", 250, 250));
                products.Add(new Product("Accessories", "Hand Bags", "AmiClubWear", "http://www.anrdoezrs.net/click-8333070-11897450", "/images/products/accessories/handbags.jpg", "Handbags, Purses, Clutches", 314, 159));
                products.Add(new Product("Accessories", "Daily Deals", "Authentic Watches", "http://www.kqzyfj.com/click-8333070-12504671", "/images/products/accessories/authentic watches.jpg", " Daily Deals Up to 50% Off - Shop Now!", 60, 60));
                products.Add(new Product("Accessories", "Engagement rings", "AnJays Designs", "http://www.tkqlhce.com/click-8333070-12681084", "/images/products/accessories/anjays.jpg", "Engagement rings inspired by nature", 80, 80));
                products.Add(new Product("Accessories", "Boots, sandals, casual shoes, women's shoes, handcrafted, clogs, men's shoes and more", "Born Shoes", "http://www.tkqlhce.com/click-8333070-12825146", "/images/products/accessories/bornshoes.jpg", "Bornshoes.com offers free shipping and exchanges on all orders, and hassle-free returns!", 140, 50));
                products.Add(new Product("Accessories", "Women's watches", "Dee Watch", "http://www.anrdoezrs.net/click-8333070-12695598", "/images/products/accessories/deewatch.jpg", "Women´s Watches, wristbands and accessories that combine Scandinavian quality and simplicity with an exclusive, romantic and bold design from southern Europe.", 300, 250));
                products.Add(new Product("Accessories", "Fashion & Accessories", "Light in the box", "http://www.anrdoezrs.net/click-8333070-12099156", "/images/products/accessories/light in the box.jpg", "Fashion, clothing, cheap fashion, wholesale clothing, jackets, winter coats, fur coats & jackets, vests, scarves, handbags, clutches, party dress, sweaters, knitwear, pants, leggings, men's jacket, shoes", 234, 60));
                products.Add(new Product("Accessories", "Hand Bags", "Naked Zebra", "http://www.kqzyfj.com/click-8333070-12828273", "/images/products/accessories/naked zebra.jpg", "The Naked Zebra collection consists of a covetable range of clothing that is accessible, easy-to-wear yet always fashion-forward, putting a modern twist on classic closet essentials. Naked Zebra's collection features everything from flattering blouses to trendy tanks and beautiful dresses in a rainbow of vibrant colors. The simple offbeat details in their high-quality, fabulous touch fabrics will allow you to express your true classy personality and make an instant fashion statement.", 300, 70));

                products.Add(new Product("Art/Photo/Music", "Free Shipping", "Fabric.com", "http://www.tkqlhce.com/click-8333070-12682006", "/images/products/art/fabric.com.jpg", "70 million women just in America alone buy these products! And they ship nearly all over the world! They havea wide range of cotton print, home décor and apparel fabrics along with crafts and notions. At any time their warehouse holds millions of yards of fabric. Whether your needs run from denim to silk, linen to faux fur, velvet to shirtings, or anywhere in between, they maintain an enormous in-stock supply of fine fabrics", 250, 250));
                products.Add(new Product("Art/Photo/Music", "The ultimate karaoke experience", "The Karaoke Channel", "http://www.dpbolvw.net/click-8333070-11086342", "/images/products/art/karaoke.jpg", "The KARAOKE Channel delivers the joy of singing to millions of karaoke fans worldwide via a library of licensed, re-recorded hit songs in the style of today's top artists and best known legends of the past in all music genres. With high quality scrolling lyric cues displayed on original concept video backgrounds and optional lead vocal tracks", 125, 125));
                products.Add(new Product("Art/Photo/Music", "Royalty-free art", "DepositPhotos.com", "http://www.kqzyfj.com/click-8333070-12409429", "/images/products/art/depositphotos.jpg", "Depositphotos is the resource for buying and selling photographs, illustrations, and vector art under the Royalty-Free license. Their fast-growing archive contains more than 32 million images along with flexible payment options and favorable terms make the most convenient and profitable tool for everyone who works with images and creates unforgettable visual content.", 320, 90));
                products.Add(new Product("Art/Photo/Music", "Collage Maker", "Ribbet", "http://www.tkqlhce.com/click-8333070-12471968", "/images/products/art/ribbet.jpg", "Ribbet is a fun and easy to use online photo editor and collage maker with beautiful filters, seasonal effects, advanced photographic touch-up tools, stickers and fonts. Our site lets you do everything from basic tasks like cropping and auto-fixing your photos, right through to sophisticated photo manipulations such as Clone and Curves. It’s simple enough that users with very little technical knowledge can work with it, and also caters for more sophisticated users including professional photographers.", 125, 125));
                products.Add(new Product("Art/Photo/Music", "Create stunning web photo albums", "jAlbum", "http://www.dpbolvw.net/click-8333070-11013476", "/images/products/art/jalbum.jpg", "jAlbum is an award winning desktop software for creating stunning web photo albums for any web site. Jalbum is simple yet one of the most powerful album tools on the planet. Everyone can use jAlbum – from professional photographers who display and sell their work through jAlbum to home users who like sharing photo albums on the net.", 250, 240));
                products.Add(new Product("Art/Photo/Music", "Biggest brands in art supplies", "MisterArt.com", "http://www.jdoqocy.com/click-8333070-12920423", "/images/products/art/misterart.jpg", "MisterArt.com has been known as the world's largest online source for discount arts and crafts supplies, such as brushes, canvases, paint, pencils, frames, clay, and much more. With fast, free shipping on orders of $200 or more and a price match guarantee, it’s no wonder customers have embraced MisterArt.com for all their artistic needs!", 300, 250));

                products.Add(new Product("Education", "Security IT Certification Exam Prep Leader", "Transcender", "http://www.jdoqocy.com/click-8333070-12864774", "/images/products/education/transcender.jpg", "Transcender offers the most realistic simulations of Microsoft, Cisco, CompTIA, CISSP, PMP and Oracle certification exams. IT Professionals worldwide consistently name Transcender simulations as the 'Best Practice Exams'", 120, 90));
                products.Add(new Product("Education", "Discount School Supplies", "Excelligence Learning Corporation", "http://www.dpbolvw.net/click-8333070-12381237", "/images/products/education/elc.jpg", "Prepare your children! Equip your children! Because they are the future! Get Free Shipping On Stock Orders Over $99", 300, 250));
                products.Add(new Product("Education", "Early childhood furniture and equipment", "Early Childhood Manufacturers' Direct (ECMD)", "http://www.kqzyfj.com/click-8333070-10809430", "/images/products/education/ecmd.jpg", "Early Childhood Manufacturers' Direct (ECMD) markets and sells the largest selection of early childhood furniture and equipment shipped direct from manufacturers to schools, preschools and early childhood programs. Shoppers receive the lowest prices on early childhood furniture and equipment", 300, 250));
                products.Add(new Product("Education", "Economist Test Prep", "Economist GMAT Tutor", "http://www.kqzyfj.com/click-8333070-11954539", "/images/products/education/etp.jpg", "Economist Test Prep is an academic division of The Economist Group that offers online GMAT and GRE preparation courses that use adaptive technology to focus on students' individual areas that need the most improvement. Economist Test Prep helps students reach their full potential by offering comprehensive lessons for every section of their tests, personalized essay marking by expert tutors, and live one-on-one academic support. The GMAT course has been highly reviewed on sites such as Beat the GMAT and GMAT Club.", 200, 200));
                products.Add(new Product("Education", "Learn a new language", "Babbel", "http://www.jdoqocy.com/click-8333070-12620241", "/images/products/education/babbel.jpg", "When you can speak another language your world becomes bigger, richer, and more inspiring. Learn with Babbel – it is fun, easy and effective. Our motivation is to provide a user-friendly, solution that allows learners to acquire a foreign language in a fun but targeted way, regardless of time or place. Anyone can learn languages; this vision has driven the Babbel team since 2007", 200, 167));
                products.Add(new Product("Education", "Free Shipping on Orders over $79; Same Day Shipping;Lowest Price Guarantee", "DiscountSchoolSupply.com", "http://www.jdoqocy.com/click-8333070-11304162", "/images/products/education/colorations.jpg", "Since 1985 Discount School Supply has been a market leader in the early childhood school supply market. Early childhood educators and parents of young children can choose from thousands of arts and crafts materials, school supplies and educational toys.", 180, 150));
                products.Add(new Product("Education", "Deal of the Week", "InformIT", "https://click.linksynergy.com/fs-bin/click?id=ifMshPN4mTc&offerid=145238.10000179&subid=0&type=4", "/images/products/education/informit.png", "InformIT is home to technology publishers Addison-Wesley Professional, Cisco Press, IBM Press, Pearson Certification, Prentice Hall Professional, QUE & Sams. They publish the top books, eBooks, & video from the creators, innovators & leaders of technology.", 300, 100));
                products.Add(new Product("Education", "Deal of the Week", "PeachPit", "https://click.linksynergy.com/fs-bin/click?id=ifMshPN4mTc&offerid=145244.10000143&subid=0&type=4", "/images/products/education/peachpit.png", "Peachpit publishes books on the latest in graphic design, desktop publishing, multimedia, Web design and development, & digital video. Peachpit also has several digital product offerings, such as eBooks and online video.", 300, 100));

                products.Add(new Product("Shops", "Men's Shirts", "CnDirect", "http://www.anrdoezrs.net/click-8333070-12923030", "/images/products/shops/cndirect.jpg", "CNDirect is committed to offering high-quality fashion products at a competitive price with fast worldwide shipping. They offer a wide assortment of merchandise, which includes clothing, shoes, jewelry, electronics, computers and phone accessories, home and garden products.", 336, 280));
                products.Add(new Product("Shops", "Dhgate Top Deals", "DHGate", "http://www.tkqlhce.com/click-8333070-11428760", "/images/products/shops/dhgate.jpg", "DHgate.com is a leading business-to-business and business-to-customer e-commerce marketplace providing an online trade platform for Chinese sellers and global buyers. You can order directly from reliable Chinese wholesalers and get worldwide delivery plus free escrow service.", 250, 250));
                products.Add(new Product("Shops", "Samsung Galaxy S6/S6 Edge Accessories Free Shipping + Up to 30% OFF!", "MiniInTheBox.com", "http://www.tkqlhce.com/click-8333070-12163567", "/images/products/shops/mininthebox.jpg", "MiniInTheBox has been a worldwide business-leader selling electronic gadgets since its inception in 2010. Servicing customers from over 170 countries, MiniInTheBox continues to expand its worldwide reach. Their amazing collection of products includes: iPhone and Samsung phone accessories, video game accessories, electronic accessories, LED lights/flashlights, computer accessories, home office gadgets, jewelry, toys, pet supplies and much more.", 250, 250));

                products.Add(new Product("Clothing/Apparel", "New Arrivals", "Kent & Curwen", "https://click.linksynergy.com/fs-bin/click?id=ifMshPN4mTc&offerid=500190.5&type=4&subid=0", "/images/products/clothing/kent&curwen.jpg", "Continuing the legacy of Kent & Curwen in the 21st century, Creative Director Daniel Kearns has taken from the authenticity of its storied past to create a wardrobe fit for the modern man. It’s about reworking the classic hallmarks of British sporting pastimes for the everyday, mixing them with menswear staples to form the foundation of the Kent & Curwen look, inspired by David Beckham’s own celebrated take on style. Daniel Kearns and David Beckham have worked collaboratively to create this new vision for Kent & Curwen.", 300, 250));
                products.Add(new Product("Clothing/Apparel", "New Arrivals", "Cerruti 1881", "https://click.linksynergy.com/fs-bin/click?id=ifMshPN4mTc&offerid=500625.4&type=4&subid=0", "/images/products/beauty/cerruti1881.jpg", "In 1881, Antonio Cerruti founded a weaving workshop in Biella, an Italian town renowned for its rich heritage in quality wool and fabric production. From these roots, the Cerruti name has expanded from luxurious fabric to acclaimed fashion without ever losing sight of its core values emphasizing quality and style, craftsmanship and technology.", 300, 250));

                products.Add(new Product("Beauty", "FREE Shipping on Charms Jewelry", "Glamulet", "http://www.jdoqocy.com/click-8333070-12091340", "/images/products/beauty/glamulet.jpg", "Your one-stop shop for rare timeless jewelry pieces. 1,000,000 + happy clients agree... With the sole aim keeping you glamorous, they offer a wide variety of modern silver jewelry charms, bracelets, necklaces and rings for the woman of today.", 450, 90));
                products.Add(new Product("Beauty", "Summer Grand SALE - 65% Off site wide", "Hair Extensions", "http://www.dpbolvw.net/click-8333070-11817525", "/images/products/beauty/hair_extensions.jpg", "Hairextensionsale.com is your online human hair extensions shop. They sell various high-quality hair extensions at very competitive prices across the world", 234, 60));
                products.Add(new Product("Beauty", "Skincare", "Suzanne Somers", "http://www.dpbolvw.net/click-8333070-11711288", "/images/products/beauty/suzannesomers.jpg", "Beauty & health products that are pure, clean and fun! Their products are made with natural botanical extracts, enzymes, skin-nurturing anti-oxidants, organic fruits and vegetables. Also, for in-home fitness, they offer products for amazing results – like the world-famous ThighMaster!", 200, 200));
                products.Add(new Product("Beauty", "Up to 58% OFF! Promotion! Shop Now!", "Cosme-De.com", "http://www.tkqlhce.com/click-8333070-12907417", "/images/products/beauty/cosmede.jpg", "COSME-DE.COM is an international online shopping site for skincare, cosmetics products and fragrances of premium brands. With over 10 years of experience in retail and wholesale of international skincare and cosmetic products in Japan, and now it’s expanded into US and international markets.", 300, 250));
                products.Add(new Product("Beauty", "Celebrate with pleasure. Save up to 50%", "Eden Fantasys", "http://www.anrdoezrs.net/click-8333070-10498399", "/images/products/beauty/edenfantasys.jpg", "EdenFantasys is a sex toys & lingerie store. They offer a great variety of products including adult sex toys, sensual oils and lubricants, erotic books, erotic educational video, erotic audio, sexy lingerie, party favorites and gags.", 300, 250));
                products.Add(new Product("Beauty", "Give the gift of fragrance or skin care to that special someone with a Perfume Emporium Gift Certificate", "Perfume Emporium", "http://www.kqzyfj.com/click-8333070-10452687", "/images/products/beauty/perfumeemporium.jpg", "Perfume Emporium is synonymous with quality and excellent customer service and offer gift certificates, gift cards, perfumes, colognes, skin care products from names such as GIORGIO ARMANI, GUCCI, LANCOME, CALVIN KLEIN, VERSACE, FENDI, TIFFANY, CARTIER", 300, 250));
                products.Add(new Product("Beauty", "FREE shipping on soap, body-wash, shampoo & conditioner", "Gilchrist & Soames", "http://www.tkqlhce.com/click-8333070-12235211", "/images/products/beauty/GilchristSoames.jpg", "Gilchrist & Soames is a leading provider of luxury toiletry collections for world-class hotels, exclusive resorts, and distinguished spas, inns, and bed & breakfasts. Specializing in servicing the luxury market, Gilchrist & Soames' products can be found in discerning properties throughout the world. Their fine toiletries, exacting customer service and commitment to environmental stewardship make us a dedicated partner who shares your passion for luxury and service.", 200, 200));
                products.Add(new Product("Beauty", "Bonus Size Cleansers! Get a BONUS sized Clarifying Cleanser for only $35 OR get the Essential-C Cleanser for only $45 at Murad.com! Shop Now! (While supplies last)", "Murad Skin-Care", "http://www.jdoqocy.com/click-8333070-12120777", "/images/products/beauty/muradskincare.jpg", "Murad® is a global leader in skincare science with a wide range of health & beauty products such as anti-aging treatments, acne treatments, age spot treatments and cellulite treatments. Product development is ongoing with new products added on a regular basis. FREE SHIPPING", 250, 250));
                products.Add(new Product("Beauty", "Explore The Possibilities With ThePerfumeSpot.com", "The Perfume Spot", "http://www.dpbolvw.net/click-8333070-12554974", "/images/products/beauty/perfumespot.jpg", "ThePerfumeSpot.com is a global online leader in discounted fragrances, bath & body products and candle. We carry over 2,000 of the hottest & most popular designer name brands including: Giorgio Armani, Swiss Army, Alfred Sung, Perry Ellis, Hugo Boss, Estee Lauder, Liz Claiborne, Calvin Klein, Guy Laroche, Givenchy, Guess, Gucci, Paris Hilton, Kenneth Cole, Elizabeth Arden, Ralph Lauren, Tommy Hilfiger, Lancôme, Christian Dior, Britney Spears, Fendi, Elizabeth Taylor plus many more. Free Shipping on orders $59 or more.", 250, 250));
                products.Add(new Product("Beauty", "FREE SHIPPING on all orders over $59", "Sabon", "https://click.linksynergy.com/fs-bin/click?id=ifMshPN4mTc&offerid=486708.18&subid=0&type=4", "/images/products/beauty/sabon.jpg", "Each unique Sabon scent collection is carefully created from highest-quality aroma extracts from around the world, by an international perfume expert. Careful consideration is given to every ingredient.", 300, 250));

                products.Add(new Product("Books/Media", "Free shipping, no minimum purchase", "ABEBooks", "http://www.jdoqocy.com/click-8333070-10640555", "/images/products/books/abeBooks.jpg", "AbeBooks is an online marketplace for books. Millions of new, used, rare, and out-of-print books are offered for sale through the AbeBooks websites from thousands of booksellers around the world. Their inventory has over 140 million books, readers find bestsellers, collectors find rare books, students find textbooks, and bargain hunters find books discounted up to 90 %.", 125, 125));
                products.Add(new Product("Books/Media", "Technical publications", "Apress", "http://www.kqzyfj.com/click-8333070-12198260", "/images/products/books/apress.jpg", "Apress is committed to supporting the ever-growing programming community by taking risks on publishing books in niche and nascent technologies. 'Apress Beginning' books provide a reliable and readable place to start learning something new, while seasoned developers have long relied on Apress Pro books to provide the no-fuss, honest approach that is needed for solving everyday problems and coverage of topics that is broad enough to support their complete career development. At the Expert level, their readers appreciate the accuracy and singular voice that their books provide for the highest-intensity of topics.", 300, 250));
                products.Add(new Product("Books/Media", "Student Discount 10% Off ", "eBooks.com", "http://www.kqzyfj.com/click-8333070-12117957", "/images/products/books/ebooks.jpg", "eBooks.com is the web's most popular digital book store with the largest range of contemporary ebooks from the world's leading publishers. With prices well below hard copy books, and the unique appeal of instantly downloadable books, sales at eBooks.com are growing exponentially.", 300, 250));
                products.Add(new Product("Books/Media", "Student textbooks", "United Campus Bookshops", "http://www.clixGalore.com/PSale.aspx?BID=151961&AfID=286234&AdID=14103&LP=ucb.net.au", "/images/products/books/ucbbanner.gif", "Avoid The Queue. Click and Collect. As a service to on-campus students, for a small fee, bookshop staff will process your on-line order, assemble your order in store, email and phone you when ready for collectiona and hold at front-desk for an easy, quick pick-up. So, avoid the queue’s at the beginning of Trimester and still receive the in-store discount.", 468, 60));

                products.Add(new Product("Automotive", "Free Shipping on Orders of $50+ Plus", "4Wheel Drive Hardware", "http://www.anrdoezrs.net/click-8333070-12867378", "/images/products/auto/4wd.jpg", "4Wheel Drive Hardware specializes in parts, accessories and gear for all makes and models of Jeeps. Consumers recognize 4WD.com as the place to search for all things Jeep and trust the 4WD.com name which has been serving the Jeep community since 1977", 300, 250));
                products.Add(new Product("Automotive", "$10 Off $75 or more", "AutoBarn", "http://www.jdoqocy.com/click-8333070-11684655", "/images/products/auto/autobarn.jpg", "AutoBarn.com brings experience, service, and a tremendous inventory of over 100,000 name-brand auto parts and accessories to customers across the world. As it is in their retail stores, superior customer service is the number one priority with online shoppers. Toll-free phone lines, knowledgeable sales associates handling incoming calls, 24-hour turnaround, 30-day satisfaction guaranteed policy, plus an unmatched selection of parts & accessories have set them apart from the rest of the online auto parts & accessories retailers", 350, 200));
                products.Add(new Product("Automotive", "Car Care Products", "Autopia", "http://www.dpbolvw.net/click-8333070-10900218", "/images/products/auto/autopia.jpg", "Autopia Car-Care, are the leader of online car-care. Their vast inventory of high-quality car-care products, auto-detailing supplies and automotive accessories includes name brand products from Sonus, Ultima, 303, Diamondite, Detailers Pro Series, Pinnacle Natural Brilliance, Wolfgang Concours Series, Lake Country Manufacturing, Mothers, Meguiars, P21S, Porter Cable, Flex Polishers to name just a few!", 120, 240));
                products.Add(new Product("Automotive", "Free E-Book: RENTING A CAR IN EUROPE", "Auto Europe", "http://www.anrdoezrs.net/click-8333070-12553641?url=http%3A%2F%2Fwww.autoeurope.com%2Fpdf%2Frenting-a-car-in-europe.pdf", "/images/products/auto/renting-a-car-in-europe.png", "For over 60 years, Auto Europe has been a leader in worldwide car rental services and helped over 10 million travelers find the best options when traveling abroad. Through their long-term relationships with top suppliers like Hertz, Avis, Enterprise, Europcar, National, Budget, Dollar, Buchbinder and Peugeot they offer travelers the best rates at 20,000 pickup locations in over 180 countries worldwide", 210, 200));

                products.Add(new Product("Health", "Flat Rate Shipping", "A1Supplements.com", "http://www.anrdoezrs.net/click-8333070-11411603", "/images/products/health/a1.jpg", "They started the online superstore to cut out the middle man and use a distribution model to offer wholesale prices direct! They now have 2 retail stores and a centralized distribution center, shipping to all states in the US and every country in the world. They are now the largest private wholesaler of supplements online, enriching lifestyles and selling supplements at 40 to 60% off retail every single day!", 234, 60));
                products.Add(new Product("Health", "Skin Care Collection", "ArtNaturals®", "http://www.anrdoezrs.net/click-8333070-12794861", "/images/products/health/art-naturals.jpg", "", 300, 250));
                products.Add(new Product("Health", "Essential Oils", "ArtNaturals®", "http://www.tkqlhce.com/click-8333070-12794855", "/images/products/health/art-naturals2.jpg", "", 250, 250));
                products.Add(new Product("Health", "Hair-Care Collection", "ArtNaturals®", "http://www.tkqlhce.com/click-8333070-12794855", "/images/products/health/art-naturals3.jpg", "", 300, 250));
                products.Add(new Product("Health", "New Discounts Every Day! Shop Now", "MedExSupply.com", "http://www.dpbolvw.net/click-8333070-11302289", "/images/products/health/medex.jpg", "MedexSupply has been an online medical distributor since 1999. With a full line of brand name products, they have established themselves in the health-care industry as the go-to provider for all of your medical, surgical, and healthcare supply needs. Their customers include government facilities, hospitals, colleges, laboratories, medical clinics, and the general public, who trust and rely on unbeatable prices, superb service, and fast shipping. With an ever-expanding inventory of more than 60,000 products, they work hard to offer every customer a hassle-free shopping experience.", 175, 350));
                products.Add(new Product("Entertainment", "Champions League", "TicketBureau International", "http://www.jdoqocy.com/click-8333070-12048863", "/images/products/entertainment/ticketbureau.jpg", "Ticket Bureau specializes in the sale of tickets for sport, music and cultural events", 300, 250));
                products.Add(new Product("Entertainment", "US Tennis Open", "Ticket Liquidators", "http://www.anrdoezrs.net/click-8333070-12394435", "/images/products/entertainment/ticketliquidator.jpg", "An industry leader with a large selection of concert, sports, and theater tickets, and more!", 300, 250));
                products.Add(new Product("Entertainment", "Cher back in Vegas", "Vegas Tickets", "http://www.jdoqocy.com/click-8333070-10699388", "/images/products/entertainment/vegastickets.jpg", "VegasTickets.com knows what happens in Vegas. Local ticket broker selling tickets for over 20 years to all Las Vegas Events and entertainment. This local Las Vegas Ticket Broker has an office located just off the world famous Strip. They sell tickets to all Headliners, Sporting Events, Concerts, and Shows featured in Las Vegas.", 300, 250));
                products.Add(new Product("Shops", "New spring catalog", "LTD Commodities", "http://www.anrdoezrs.net/click-8333070-11932638", "/images/products/shops/ltdcommodities.jpg", "LTD Commodities offers amazing deals on the most popular products in the marketplace. They have unbelievably low prices on everything from gifts and apparel to toys, electronics and housewares. They're a popular shopping destination for holidays, special events, business and home accessories and so much more. Their wide variety, excellent customer service and satisfaction guarantee make LTD Commodities a great partner choice. Log on to their website and see how you can save big every day", 300, 250));
                products.Add(new Product("Travel", "Business Travel", "About Airport Parking", "http://www.tkqlhce.com/click-8333070-10910776", "/images/products/travel/aboutairportparking.jpg", "AboutAirportParking.com is the leading independent airport parking directory and reservation network on the internet. They enable travelers to compare airport parking lots and find & reserve a space for almost always less than the drive-up price. They make it possible to use the handy tools people are accustomed to using when shopping online for other products, such as price comparisons, objective genuine user reviews, and maps. Since you're already booking your flight and hotel online, why not your parking spot!", 300, 250));
                products.Add(new Product("Travel", "Advertise a Room", "Easy Room-mate", "http://www.anrdoezrs.net/click-8333070-12451465", "/images/products/travel/easyroommate.jpg", "EasyRoommate is the largest flatshare website in the world. They connect landlords with tenants and help flatmates find great rooms to rent. They aim to make it easy to find the perfect place to rent and also provide a safe and secure platform. With a service across 24 countries in 8 different languages and with more than 100,000 live listings globally, they are the world’s number 1 flatshare and room rental website today.", 300, 250));
                products.Add(new Product("Travel", "Save 30% on Car Rentals in Europe", "", "http://www.tkqlhce.com/click-8333070-12633829", "/images/products/travel/autoeurope.jpg", "Auto Europe is the best kept secret in the travel industry. They have been helping travelers find the best rental car rates around the world for over 60 years. With a deep understanding of the complexities of renting cars abroad, and 24/7 availability of rental experts, they provide the best service in the industry before, during and after the rental.", 300, 250));
                products.Add(new Product("Travel", "Exclusive vacation packages to Europe, at great prices!", "Azores Getaways", "http://www.dpbolvw.net/click-8333070-12845179", "/images/products/travel/azores.jpg", "AzoresGetaways.com has the absolute best inventory for the Azores, Madeira Islands and mainland Portugal, offering tailored deals by local experts with the best hotels and activities.", 300, 250));
                products.Add(new Product("Clothing/Apparel", "Shop at DressLily and dress to express", "Dresslily.com", "https://click.linksynergy.com/fs-bin/click?id=ifMshPN4mTc&offerid=489242.3&subid=0&type=4", "/images/products/clothing/dresslily.jpg", "DressLily.com is a leading online fashion shop which offers the latest clothing & accessories at unbeatable prices with Global Free Shipping. Our products mainly cover Dresses, Women's Tops, Women's Sweaters & Cardigans, Women's Outwear, Swimwear, Shoes, Bags, Jewelries, Watches, Men's Clothing, etc", 200, 200));

                products.Add(new Product("Stores/Malls", "All the gadgets you dream about!", "GeekBuying.com", "https://click.linksynergy.com/fs-bin/click?id=ifMshPN4mTc&offerid=460195.552&type=4&subid=0", "/images/products/shops/geekbuying.jpg", "GeekBuying.com was built to offer the coolest gadgets to the whole world at incredible low prices. They know that although online shopping is very popular the fun of real-life shopping is often missing. So they'd like to add some fun to your online shopping experience. At GeekBuying, you will get fun in shopping. No matter whether or not you are a geek, you're sure to enjoy shopping at GeekBuying. They work passionately to exceed your expectations every time. Once you buy, you know.", 300, 250));

                products.Add(new Product("FrontPage", "New Baby Planter w/Fresh Flower Accents", "", "http://www.anrdoezrs.net/85116xdmjdl09444181021385127?url=https%3A%2F%2Fwww.800florals.com%2Forder.asp%3Fitem%3D0184X%26ID%3D%40AF1&cjsku=0184X", "/images/index/baby planter.jpg", "New Baby Planter", 300, 250));
                products.Add(new Product("FrontPage", "Autumn Harvest Basket", "", "http://www.tkqlhce.com/bf106y1A719PYTTTQXQPRQSXUQRW?url=https%3A%2F%2Fwww.800florals.com%2Forder.asp%3Fitem%3DP250X%26ID%3D%40AF1&cjsku=P250X", "/images/index/autumn harvest.jpg", "Harvest Time Basket (Autumn)", 300, 250));
                products.Add(new Product("FrontPage", "12 Vased Roses", "", "http://www.tkqlhce.com/31111wktqks7GBBB8F8798AFC89E?url=https%3A%2F%2Fwww.800florals.com%2Forder.asp%3Fitem%3D3664X%26ID%3D%40AF1&cjsku=3664X", "/images/index/12 vased roses.jpg", "One Dozen Roses Vased", 200, 200));
                products.Add(new Product("FrontPage", "Sincere Condolences", "", "http://www.tkqlhce.com/m7122mu2-u1HQLLLIPIHJIKPMIJO?url=https%3A%2F%2Fwww.800florals.com%2Forder.asp%3Fitem%3D4554X%26ID%3D%40AF1&cjsku=4554X", "/images/index/condolences.jpg", "FTD Deepest Sympathy Flowers Arrangement", 200, 200));

                products.Add(new Product("FrontPage", "Konjac Facial Sponge Set", "", "http://www.jdoqocy.com/click-8333070-12688492?url=https%3A%2F%2Fartnaturals.com%2Fproducts%2Fkonjac-facial-sponge-set&cjsku=ANTA-5008", "/images/index/Konjac-Facial-Sponge-Set.jpg", "Konjac Facial Sponge Set", 200, 200));
                products.Add(new Product("FrontPage", "Eucalyptus Oil Set (4 oz./118ml)", "", "http://www.jdoqocy.com/click-8333070-12688492?url=https%3A%2F%2Fartnaturals.com%2Fproducts%2Fart-naturals-eucalyptus-oil&cjsku=ANVA-0416", "/images/index/AN_Eucalyptus-Oil.jpg", "Eucalyptus Oil Set (4 oz./118ml)", 200, 200));
                products.Add(new Product("FrontPage", "Tea Tree Oil Body Wash", "", "http://www.kqzyfj.com/click-8333070-12688492?url=https%3A%2F%2Fartnaturals.com%2Fproducts%2Fart-naturals-tea-tree-body-wash&cjsku=ANBA-0403", "/images/index/ANBodyWash.jpg", "Tea Tree Oil Body Wash", 200, 200));
                products.Add(new Product("FrontPage", "Himalayan Salt Scrub", "", "http://www.anrdoezrs.net/click-8333070-12688492?url=https%3A%2F%2Fartnaturals.com%2Fproducts%2Fart-naturals-himalayan-salt-scrub&cjsku=ANFA-2002", "/images/index/Himalayan-Salt-Scrub.jpg", "Himalayan Salt Scrub", 200, 200));


                products.Add(new Product("FrontPage", "Cargo cosmetics for men", "", "http://www.dpbolvw.net/click-8333070-12371998", "/images/products/beauty/cargobanner.jpg", "Cargo cosmetics for men", 200, 200));
                products.Add(new Product("FrontPage", "Murad Skin Care", "", "http://www.jdoqocy.com/click-8333070-12271848", "/images/products/beauty/muradbanner.jpg", "Murad Skin-Care", 200, 200));
                products.Add(new Product("FrontPage", "Sabon Beauty Products", "", "https://click.linksynergy.com/fs-bin/click?id=ifMshPN4mTc&offerid=486708.19&subid=0&type=4", "/images/products/beauty/sabonbanner.jpg", "Sabon Beauty Products", 200, 200));
                products.Add(new Product("FrontPage", "100% Human Hair Extensions on Sale - Free Shipping WorldWide", "", "http://www.tkqlhce.com/click-8333070-11405049", "/images/products/beauty/hairextensions.jpg", "100% Human Hair Extensions on Sale - Free Shipping WorldWide", 200, 200));
                products.Add(new Product("FrontPage", "Coastal Scents", "", "http://www.anrdoezrs.net/click-8333070-12540174", "/images/products/beauty/coastalscents.jpg", "Coastal Scents", 200, 200));
                products.Add(new Product("FrontPage", "", "", "http://www.jdoqocy.com/click-8333070-12905677", "/images/products/beauty/cosmede1.jpg", "", 200, 200));

                products.Add(new Product("FrontPage", "TeleFloral Australia", "", "http://www.clixGalore.com/PSale.aspx?BID=176938&AfID=286234&AdID=14378&LP=pin.petals.com.au%2fai5983auen.html", "/images/products/gifts/telefloral.gif", "TeleFloral Australia", 200, 200));
                products.Add(new Product("FrontPage", "Send Holiday Flowers", "", "http://www.kqzyfj.com/click-8333070-7004864", "/images/products/gifts/seasonalflowers.jpg", "Send Holiday Flowers", 200, 200));

                //products.Add(new Product("FrontPage", "","","","","",200,200));
                //products.Add(new Product("FrontPage", "","","","","",200,200));
                //products.Add(new Product("FrontPage", "","","","","",200,200));


                //products.Add(new Product("","","","","",200,200));
                //products.Add(new Product("","","","","",200,200));
                //products.Add(new Product("","","","","",200,200));
                //products.Add(new Product("","","","","",200,200));
                //products.Add(new Product("","","","","",200,200));
                //products.Add(new Product("","","","","",200,200));
                //products.Add(new Product("","","","","",200,200));
                //products.Add(new Product("","","","","",200,200));
                //products.Add(new Product("","","","","",200,200));
                //products.Add(new Product("","","","","",200,200));
                //products.Add(new Product("","","","","",200,200));
                //products.Add(new Product("","","","","",200,200));
                //products.Add(new Product("","","","","",200,200));
                //products.Add(new Product("","","","","",200,200));
                //products.Add(new Product("","","","","",200,200));
                //products.Add(new Product("","","","","",200,200));
                //products.Add(new Product("","","","","",200,200));
                //products.Add(new Product("","","","","",200,200));
                //products.Add(new Product("","","","","",200,200));
                //products.Add(new Product("","","","","",200,200));
                //products.Add(new Product("","","","","",200,200));
                //products.Add(new Product("","","","","",200,200));
                //products.Add(new Product("","","","","",200,200));
                //products.Add(new Product("","","","","",200,200));
                //products.Add(new Product("","","","","",200,200));
                //products.Add(new Product("","","","","",200,200));
                //products.Add(new Product("","","","","",200,200));
                //products.Add(new Product("","","","","",200,200));
                //products.Add(new Product("","","","","",200,200));
                //products.Add(new Product("","","","","",200,200));
                //products.Add(new Product("","","","","",200,200));
                //products.Add(new Product("","","","","",200,200));
                //products.Add(new Product("","","","","",200,200));
                //products.Add(new Product("","","","","",200,200));
                //products.Add(new Product("","","","","",200,200));
                //products.Add(new Product("","","","","",200,200));
                //products.Add(new Product("","","","","",200,200));
                //products.Add(new Product("","","","","",200,200));
                //products.Add(new Product("","","","","",200,200));
                //products.Add(new Product("","","","","",200,200));
                //products.Add(new Product("","","","","",200,200));
                //products.Add(new Product("","","","","",200,200));
                //products.Add(new Product("","","","","",200,200));
                //products.Add(new Product("","","","","",200,200));
                //products.Add(new Product("","","","","",200,200));
                //products.Add(new Product("","","","","",200,200));
                //products.Add(new Product("","","","","",200,200));
                //products.Add(new Product("","","","","",200,200));
                //products.Add(new Product("","","","","",200,200));
                //products.Add(new Product("","","","","",200,200));
                //products.Add(new Product("","","","","",200,200));
                //products.Add(new Product("","","","","",200,200));
                //products.Add(new Product("","","","","",200,200));
                //products.Add(new Product("","","","","",200,200));
                //products.Add(new Product("","","","","",200,200));
                //products.Add(new Product("","","","","",200,200));
                //products.Add(new Product("","","","","",200,200));
                //products.Add(new Product("","","","","",200,200));
                //products.Add(new Product("","","","","",200,200));
                //products.Add(new Product("","","","","",200,200));
                //products.Add(new Product("","","","","",200,200));
                //products.Add(new Product("","","","","",200,200));
                //products.Add(new Product("","","","","",200,200));
                //products.Add(new Product("","","","","",200,200));
                //products.Add(new Product("","","","","",200,200));
                //products.Add(new Product("","","","","",200,200));
                //products.Add(new Product("","","","","",200,200));
                //products.Add(new Product("","","","","",200,200));
                //products.Add(new Product("","","","","",200,200));
                //products.Add(new Product("","","","","",200,200));
                //products.Add(new Product("","","","","",200,200));
                //products.Add(new Product("","","","","",200,200));
                //products.Add(new Product("","","","","",200,200));
                //products.Add(new Product("","","","","",200,200));
                //products.Add(new Product("","","","","",200,200));
                //products.Add(new Product("","","","","",200,200));
                //products.Add(new Product("","","","","",200,200));
                //products.Add(new Product("","","","","",200,200));
                //products.Add(new Product("","","","","",200,200));
                //products.Add(new Product("","","","","",200,200));
                //products.Add(new Product("","","","","",200,200));
                //products.Add(new Product("","","","","",200,200));
                //products.Add(new Product("","","","","",200,200));
                //products.Add(new Product("","","","","",200,200));
                //products.Add(new Product("","","","","",200,200));
                //products.Add(new Product("","","","","",200,200));
                //products.Add(new Product("","","","","",200,200));
                //products.Add(new Product("","","","","",200,200));
                //products.Add(new Product("","","","","",200,200));
                //products.Add(new Product("","","","","",200,200));
                //products.Add(new Product("","","","","",200,200));
                //products.Add(new Product("","","","","",200,200));
                //products.Add(new Product("","","","","",200,200));
                //products.Add(new Product("","","","","",200,200));
                //products.Add(new Product("","","","","",200,200));
                //products.Add(new Product("","","","","",200,200));
                //products.Add(new Product("","","","","",200,200));
                //products.Add(new Product("","","","","",200,200));
                //products.Add(new Product("","","","","",200,200));
            }
            products.OrderBy(o => o.Category).ToList();
            List<Product> pl = products.Where(p => p.Category == category).ToList();
            pl.OrderBy(p => p.Name);
            ViewBag.Products = pl;
            SetCats();
            foreach (var c in ViewBag.catList)
            {
                c.Count = products.Where(l => l.Category == c.Name).ToList().Count;
            }
            ViewBag.FrontPage = products.Where(p => p.Category == "FrontPage").ToList();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";
            return View();
        }

        public void SetCats()
        {
            List<Category> catlist = new List<Category>();

            catlist.Add(new Category("Accessories", "Accessories", new List<SubCategory>() { new SubCategory("Handbags", ""), new SubCategory("Jewelry", ""), new SubCategory("Shoes", "") }));
            catlist.Add(new Category("Art/Photo/Music", "Art", new List<SubCategory>() { new SubCategory("Art", ""), new SubCategory("Music", ""), new SubCategory("Photo", "") }));
            catlist.Add(new Category("Automotive", "Auto", new List<SubCategory>() { new SubCategory("Cars & Trucks", ""), new SubCategory("Motorcycles", ""), new SubCategory("Parts & Accessories", ""), new SubCategory("Rentals", ""), new SubCategory("Tools and Supplies", "") }));
            catlist.Add(new Category("Beauty", "Beauty", new List<SubCategory>() { new SubCategory("Bath & Body", ""), new SubCategory("Cosmetics", ""), new SubCategory("Fragrance", ""), new SubCategory("Green", "") }));
            catlist.Add(new Category("Books/Media", "Books", new List<SubCategory>() { new SubCategory("Audio Books", ""), new SubCategory("Books", ""), new SubCategory("Magazines", ""), new SubCategory("News", ""), new SubCategory("Television", ""), new SubCategory("Videos/Movies", "") }));
            catlist.Add(new Category("Business", "Business", new List<SubCategory>() { new SubCategory("Business-to-Business", ""), new SubCategory("Marketing", ""), new SubCategory("Office", ""), new SubCategory("Productivity Tools", ""), new SubCategory("Travel", "") }));
            catlist.Add(new Category("Buying/Selling", "Buying", new List<SubCategory>() { new SubCategory("Auction", ""), new SubCategory("Classifieds", ""), new SubCategory("E-commerce Solutions/Providers", ""), new SubCategory("New/Used Goods", "") }));
            catlist.Add(new Category("Careers", "Careers", new List<SubCategory>() { new SubCategory("Employment", ""), new SubCategory("Military", "") }));
            catlist.Add(new Category("Clothing/Apparel", "Clothing", new List<SubCategory>() { new SubCategory("Childrens", ""), new SubCategory("Green", ""), new SubCategory("Malls", ""), new SubCategory("Men's", ""), new SubCategory("Women's", "") }));
            catlist.Add(new Category("Computers/Electronics", "Computers", new List<SubCategory>() { new SubCategory("Computer HW", ""), new SubCategory("Computer SW", ""), new SubCategory("Computer Support", ""), new SubCategory("Consumer Electronics", ""), new SubCategory("Green", ""), new SubCategory("Peripherals", "") }));
            catlist.Add(new Category("Stores/Malls", "Shops", new List<SubCategory>() { new SubCategory("Department Stores", ""), new SubCategory("Virtual Malls", "") }));
            catlist.Add(new Category("Education", "Education", new List<SubCategory>() { new SubCategory("Children", ""), new SubCategory("College", ""), new SubCategory("Languages", ""), new SubCategory("Professional", "") }));
            catlist.Add(new Category("Entertainment", "Entertainment", new List<SubCategory>() { new SubCategory("Discounts", ""), new SubCategory("Events", ""), new SubCategory("Guides", ""), new SubCategory("Memorabilia", ""), new SubCategory("Mobile Entertainment", ""), new SubCategory("Party Goods", "") }));
            catlist.Add(new Category("Family", "Family", new List<SubCategory>() { new SubCategory("Babies", ""), new SubCategory("Children", ""), new SubCategory("Entertainment", ""), new SubCategory("Teens", ""), new SubCategory("Weddings", "") }));
            catlist.Add(new Category("Financial Services", "Money", new List<SubCategory>() { new SubCategory("Banking/Trading", ""), new SubCategory("Credit Cards", ""), new SubCategory("Credit Reporting and Repair", ""), new SubCategory("Investment", ""), new SubCategory("Mortgage Loans", ""), new SubCategory("Personal Loans", ""), new SubCategory("Real Estate Services", ""), new SubCategory("Tax Services", "") }));
            catlist.Add(new Category("Food/Drinks", "Food", new List<SubCategory>() { new SubCategory("Gourmet", ""), new SubCategory("Green", ""), new SubCategory("Groceries", ""), new SubCategory("Restaurants", ""), new SubCategory("Wine & Spirits", "") }));
            catlist.Add(new Category("Games/Toys", "Games", new List<SubCategory>() { new SubCategory("Electronic Games", ""), new SubCategory("Electronic Toys", ""), new SubCategory("Games", ""), new SubCategory("Toys", "") }));
            catlist.Add(new Category("Gifts/Flowers", "Gifts", new List<SubCategory>() { new SubCategory("Collectibles", ""), new SubCategory("Flowers", ""), new SubCategory("Gifts", ""), new SubCategory("Green", ""), new SubCategory("Greeting Cards", "") }));
            catlist.Add(new Category("Health/Wellness", "Health", new List<SubCategory>() { new SubCategory("Equipment", ""), new SubCategory("Green", ""), new SubCategory("Health Food", ""), new SubCategory("Nutritional Supplements", ""), new SubCategory("Pharmaceuticals", ""), new SubCategory("Self Help", ""), new SubCategory("Vision Care", ""), new SubCategory("Weight Loss", ""), new SubCategory("Wellness", "") }));
            catlist.Add(new Category("Home/Garden", "Home", new List<SubCategory>() { new SubCategory("Bed & Bath", ""), new SubCategory("Construction", ""), new SubCategory("Energy Saving", ""), new SubCategory("Furniture", ""), new SubCategory("Garden", ""), new SubCategory("Green", ""), new SubCategory("Home Appliances", ""), new SubCategory("Kitchen", ""), new SubCategory("Pets", ""), new SubCategory("Real Estate", ""), new SubCategory("Recycling", ""), new SubCategory("Utilities", "") }));
            catlist.Add(new Category("Insurance", "Insurance", new List<SubCategory>() { new SubCategory("Commercial", ""), new SubCategory("Personal Insurance", "") }));
            catlist.Add(new Category("Legal", "Legal", new List<SubCategory>() { new SubCategory("Services", "") }));
            catlist.Add(new Category("Marketing", "Marketing", new List<SubCategory>() { new SubCategory("Business-to-Business", ""), new SubCategory("Network Marketing", "") }));
            catlist.Add(new Category("Non-Profit", "NonProfit", new List<SubCategory>() { new SubCategory("Charitable Organizations", ""), new SubCategory("Fundraising", "") }));
            catlist.Add(new Category("Online Services", "Online", new List<SubCategory>() { new SubCategory("Blogs", ""), new SubCategory("Broadband", ""), new SubCategory("Domain Registrations", ""), new SubCategory("Email Marketing", ""), new SubCategory("Internet Service Providers", ""), new SubCategory("Search Engine", ""), new SubCategory("Web Design", ""), new SubCategory("Web Hosting/Servers", ""), new SubCategory("Web Tools", "") }));
            catlist.Add(new Category("Recreation/Leisure", "Recreation", new List<SubCategory>() { new SubCategory("Astrology", ""), new SubCategory("Betting/Gaming", ""), new SubCategory("Camping and Hiking", ""), new SubCategory("Communities", ""), new SubCategory("Green", ""), new SubCategory("Matchmaking", ""), new SubCategory("Outdoors", "") }));
            catlist.Add(new Category("Seasonal", "Seaonal", new List<SubCategory>() { new SubCategory("Autumn", ""), new SubCategory("Back to School", ""), new SubCategory("Black Friday/Cyber Monday", ""), new SubCategory("Christmas", ""), new SubCategory("Easter", ""), new SubCategory("Father's Day", ""), new SubCategory("Halloween", ""), new SubCategory("Mother's Day", ""), new SubCategory("New Year's Resolution", ""), new SubCategory("Spring", ""), new SubCategory("Summer", ""), new SubCategory("Tax Season", ""), new SubCategory("Valentine's Day", ""), new SubCategory("Winter", "") }));
            catlist.Add(new Category("Sports/Fitness", "Sports", new List<SubCategory>() { new SubCategory("Apparel", ""), new SubCategory("Collectibles and Memorabilia", ""), new SubCategory("Equipment", ""), new SubCategory("Exercise & Health", ""), new SubCategory("Golf", ""), new SubCategory("Professional Sports Organizations", ""), new SubCategory("Sports", ""), new SubCategory("Summer Sports", ""), new SubCategory("Water Sports", ""), new SubCategory("Winter Sports", "") }));
            catlist.Add(new Category("Telecommunications", "Communications", new List<SubCategory>() { new SubCategory("Online/Wireless", ""), new SubCategory("Phone Card Services", ""), new SubCategory("Telephone Services", "") }));
            catlist.Add(new Category("Travel", "Travel", new List<SubCategory>() { new SubCategory("Accessories", ""), new SubCategory("Air", ""), new SubCategory("Car", ""), new SubCategory("Green", ""), new SubCategory("Hotel", ""), new SubCategory("Luggage", ""), new SubCategory("Vacation", "") }));

            ViewBag.Catlist = catlist.OrderBy(c => c.Name).ToList();
        }

        public class Category
        {
            public Category(string n, string l, List<SubCategory> s)
            {
                Name = n;
                Link = l;
                Subcategories = s;
            }
            public string Name { get; set; }
            public string Link { get; set; }
            public int Count { get; set; }
            public List<SubCategory> Subcategories { get; set; }
        }

        public class SubCategory
        {
            public SubCategory(string n, string l)
            {
                Name = n;
                Link = l;
            }

            public string Name { get; set; }
            public string Link { get; set; }

        }

        public class Product
        {
            public Product(string c, string n, string s, string l, string p, string d, int w, int h)
            {
                Category = c;
                Name = n;
                Supplier = s;
                Link = l;
                Source = p;
                Description = d;
                Width = w;
                Height = h;
            }

            public string Category { get; set; }
            public string Name { get; set; }
            public string Supplier { get; set; }
            public string Link { get; set; }
            public string Source { get; set; }
            public string Description { get; set; }
            public int Width { get; set; }
            public int Height { get; set; }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

