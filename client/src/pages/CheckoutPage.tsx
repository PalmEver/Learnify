import { Elements } from "@stripe/react-stripe-js";
import { loadStripe } from "@stripe/stripe-js";
import { useEffect } from "react";
import agent from "../actions/agent";
import Checkout from "../components/Checkout";
import { setBasket } from "../redux/slice/basketSlice";
import { useAppDispatch } from "../redux/store/configureStore";

const stripePromise = loadStripe(
  "pk_test_51LmINJH2CTCmsVfmt3eMhptfavvGgyRcYpvuuRwimh72d6s5RMW45rvT5HjsUP4x81YqfKtlXfpeLLRaLaJrFXrt00mnKLJxMJ"
);

export default function CheckoutPage() {
  const dispatch = useAppDispatch();

  useEffect(() => {
    agent.Payments.paymentIntent()
      .then((basket) => dispatch(setBasket(basket)))
      .catch((error) => console.log(error));
  }, [dispatch]);

  return (
    <Elements stripe={stripePromise}>
      <Checkout />
    </Elements>
  );
}
