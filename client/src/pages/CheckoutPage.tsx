import { Elements } from "@stripe/react-stripe-js";
import { loadStripe } from "@stripe/stripe-js";
import Checkout from "../components/Checkout";

const stripePromise = loadStripe(
  "pk_test_51LmINJH2CTCmsVfmt3eMhptfavvGgyRcYpvuuRwimh72d6s5RMW45rvT5HjsUP4x81YqfKtlXfpeLLRaLaJrFXrt00mnKLJxMJ"
);

export default function CheckoutPage() {
  return (
    <Elements stripe={stripePromise}>
      <Checkout />
    </Elements>
  );
}
