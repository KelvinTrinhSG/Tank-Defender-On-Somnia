public static class ContractConfig
{
    public static readonly string NFT_CONTRACT = "0x9aEBF83Aa77dA3fcB451Da8C9dfcbE595f18feD2";
    public static readonly string GOLD_CONTRACT = "0x40D68BA05da78d2644aB831469CAa81A1EC71e66";
    public static readonly string TOKEN_CONTRACT = "0x74F411F2a3B0cAea8F256Ee735937978A6FE8c51";
    public static readonly string LEVEL_CONTRACT = "0x579558E805cEf9374E5C75A45B989e38Eae4cA95";

    public static readonly string LEVEL_CONTRACT_ABI = "[{\"inputs\":[{\"internalType\":\"address\",\"name\":\"_player\",\"type\":\"address\"}],\"name\":\"getLevel\",\"outputs\":[{\"internalType\":\"uint256\",\"name\":\"\",\"type\":\"uint256\"}],\"stateMutability\":\"view\",\"type\":\"function\"},{\"inputs\":[{\"internalType\":\"address\",\"name\":\"\",\"type\":\"address\"}],\"name\":\"levels\",\"outputs\":[{\"internalType\":\"uint256\",\"name\":\"\",\"type\":\"uint256\"}],\"stateMutability\":\"view\",\"type\":\"function\"},{\"inputs\":[{\"internalType\":\"uint256\",\"name\":\"_newLevel\",\"type\":\"uint256\"}],\"name\":\"updateLevel\",\"outputs\":[],\"stateMutability\":\"nonpayable\",\"type\":\"function\"}]";
}
